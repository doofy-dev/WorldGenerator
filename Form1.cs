using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WorldGenerator2
{
    public partial class WorldGenerator : Form
    {
        Thread t = null;
        int timerc = 0;
        int timerc2 = 0;
        float averagecps = 0;
        public WorldGenerator()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            size.Text = statics.WorldSize.ToString();
            octaves.Text = statics.WorldGenerationOctaves.ToString();
            lacurancy.Text = statics.WorldGenerationLacuranity.ToString();
            gain.Text = statics.WorldGenerationGain.ToString();
            amplitude.Text = statics.WorldGenerationAmplitude.ToString();
            frequency.Text = statics.WorldGenerationFrequency.ToString();
            level1.Text = statics.levels[0].ToString();
            level2.Text = statics.levels[1].ToString();
            level3.Text = statics.levels[2].ToString();
            level4.Text = statics.levels[3].ToString();
            seed.Text = statics.WorldSeed;
        }

        private void generate_Click(object sender, EventArgs e)
        {
            
            statics.percentage =0;
            Generate g = new Generate();
            statics.WorldSize = Convert.ToInt32(size.Text);
            statics.WorldGenerationOctaves = Convert.ToInt32(octaves.Text);
            statics.WorldGenerationLacuranity = float.Parse(lacurancy.Text);
            statics.WorldGenerationGain = float.Parse(gain.Text);
            statics.WorldGenerationAmplitude = float.Parse(amplitude.Text);
            statics.WorldGenerationFrequency = float.Parse(frequency.Text);
            statics.levels = new float[4] { float.Parse(level1.Text), float.Parse(level2.Text), float.Parse(level3.Text), float.Parse(level4.Text) };
            statics.WorldSeed = seed.Text;

            //APPLY SEED
            Random rand = new Random(unchecked(statics.WorldSeed.GetHashCode()));
            statics.bmp = new Bitmap(Convert.ToInt32(size.Text) * 16, Convert.ToInt32(size.Text) * 16);
            for (int i = 0; i < Noise.perm.Length; i++)
            {
                Noise.perm[i] = (byte)rand.Next(256);
            }

            button1.Enabled = false;
            timer1.Start();
            generate.Enabled = false;
            statics.finished = false;
            t = new Thread(g.startGeneration);
            t.Start();
        }
        private int[] timeLeft(int timeinsec)
        {
            int hour = (int)((timeinsec / 60) / 60);
            timeinsec -= (hour * 60 * 60);
            int min = (int)(timeinsec / 60);
            int sec = timeinsec - (min * 60);
            
            return new int[]{hour,min,sec};
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progr.Value = Convert.ToInt32(statics.percentage);
            percval.Text = Convert.ToInt32(statics.percentage) + " %";

            if (timerc2 == 10)
            {
                
            }
            if (timerc == 10)
            {
                averagecps += statics.cps;
                averagecps = averagecps / 1.3f;
                int[] gettime = timeLeft( (int)(((statics.WorldSize * statics.WorldSize) - statics.cpdone) / averagecps));
                timeleft.Text = (gettime[0] < 10 ? "0" : "") + gettime[0] + ":" + (gettime[1] < 10 ? "0" : "") + gettime[1] + ":" + (gettime[2] < 10 ? "0" : "") + gettime[2];
                chunkpersec.Text = statics.cps.ToString()+" cps";
               
                statics.cps = 0;
                timerc = 0;
            }
            
            timerc2++;
            timerc++;
            if (statics.finished)
            {
                timeleft.Text = "00:00:00";
                statics.cpdone = 0;
              
                chunkpersec.Text = "";
                statics.cps = 0;
                averagecps = 0;
                timerc = 0;
                timerc2 = 0;
                percval.Text = "0 %";
                progr.Value = 0;
                button1.Enabled = true;
                generate.Enabled = true;
                if (t != null)
                {
                    t.Abort();
                }
                splitContainer1.Panel2.BackgroundImage = statics.bmp;
                timer1.Stop();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t != null) t.Abort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "unknown.bmp";
            saveFileDialog1.Filter = "BMP Files (*.bmp)|*.bmp";
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                statics.bmp.Save(saveFileDialog1.FileName);
            }
           // .FileName = "unknown.txt";

        }
    }
}
