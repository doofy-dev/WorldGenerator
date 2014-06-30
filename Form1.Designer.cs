namespace WorldGenerator2
{
    partial class WorldGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chunkpersec = new System.Windows.Forms.Label();
            this.seed = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.percval = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progr = new System.Windows.Forms.ProgressBar();
            this.generate = new System.Windows.Forms.Button();
            this.level4 = new System.Windows.Forms.TextBox();
            this.level3 = new System.Windows.Forms.TextBox();
            this.level2 = new System.Windows.Forms.TextBox();
            this.level1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.frequency = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.amplitude = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lacurancy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.octaves = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timeleft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.timeleft);
            this.splitContainer1.Panel1.Controls.Add(this.chunkpersec);
            this.splitContainer1.Panel1.Controls.Add(this.seed);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.percval);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.progr);
            this.splitContainer1.Panel1.Controls.Add(this.generate);
            this.splitContainer1.Panel1.Controls.Add(this.level4);
            this.splitContainer1.Panel1.Controls.Add(this.level3);
            this.splitContainer1.Panel1.Controls.Add(this.level2);
            this.splitContainer1.Panel1.Controls.Add(this.level1);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.frequency);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.amplitude);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.gain);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.lacurancy);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.octaves);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.size);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splitContainer1.Size = new System.Drawing.Size(700, 568);
            this.splitContainer1.SplitterDistance = 95;
            this.splitContainer1.TabIndex = 0;
            // 
            // chunkpersec
            // 
            this.chunkpersec.AutoSize = true;
            this.chunkpersec.Location = new System.Drawing.Point(13, 62);
            this.chunkpersec.Name = "chunkpersec";
            this.chunkpersec.Size = new System.Drawing.Size(0, 13);
            this.chunkpersec.TabIndex = 23;
            // 
            // seed
            // 
            this.seed.Location = new System.Drawing.Point(404, 72);
            this.seed.Name = "seed";
            this.seed.Size = new System.Drawing.Size(189, 20);
            this.seed.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Seed";
            // 
            // percval
            // 
            this.percval.Location = new System.Drawing.Point(13, 60);
            this.percval.Name = "percval";
            this.percval.Size = new System.Drawing.Size(373, 16);
            this.percval.TabIndex = 20;
            this.percval.Text = "0 %";
            this.percval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progr
            // 
            this.progr.Location = new System.Drawing.Point(13, 79);
            this.progr.Name = "progr";
            this.progr.Size = new System.Drawing.Size(373, 10);
            this.progr.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progr.TabIndex = 18;
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(613, 27);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(75, 23);
            this.generate.TabIndex = 17;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // level4
            // 
            this.level4.Location = new System.Drawing.Point(570, 29);
            this.level4.Name = "level4";
            this.level4.Size = new System.Drawing.Size(23, 20);
            this.level4.TabIndex = 16;
            // 
            // level3
            // 
            this.level3.Location = new System.Drawing.Point(541, 29);
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(23, 20);
            this.level3.TabIndex = 15;
            // 
            // level2
            // 
            this.level2.Location = new System.Drawing.Point(512, 29);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(23, 20);
            this.level2.TabIndex = 14;
            // 
            // level1
            // 
            this.level1.Location = new System.Drawing.Point(483, 29);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(23, 20);
            this.level1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(480, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Levels";
            // 
            // frequency
            // 
            this.frequency.Location = new System.Drawing.Point(404, 29);
            this.frequency.Name = "frequency";
            this.frequency.Size = new System.Drawing.Size(58, 20);
            this.frequency.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Frequency";
            // 
            // amplitude
            // 
            this.amplitude.Location = new System.Drawing.Point(328, 29);
            this.amplitude.Name = "amplitude";
            this.amplitude.Size = new System.Drawing.Size(58, 20);
            this.amplitude.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amplitude";
            // 
            // gain
            // 
            this.gain.Location = new System.Drawing.Point(253, 29);
            this.gain.Name = "gain";
            this.gain.Size = new System.Drawing.Size(58, 20);
            this.gain.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gain";
            // 
            // lacurancy
            // 
            this.lacurancy.Location = new System.Drawing.Point(177, 29);
            this.lacurancy.Name = "lacurancy";
            this.lacurancy.Size = new System.Drawing.Size(58, 20);
            this.lacurancy.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lacurancy";
            // 
            // octaves
            // 
            this.octaves.Location = new System.Drawing.Point(98, 29);
            this.octaves.Name = "octaves";
            this.octaves.Size = new System.Drawing.Size(58, 20);
            this.octaves.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Octaves";
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(16, 29);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(58, 20);
            this.size.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeleft
            // 
            this.timeleft.Location = new System.Drawing.Point(328, 59);
            this.timeleft.Name = "timeleft";
            this.timeleft.Size = new System.Drawing.Size(58, 19);
            this.timeleft.TabIndex = 24;
            this.timeleft.Text = "00:00:00";
            this.timeleft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WorldGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 568);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WorldGenerator";
            this.Text = "WorldGenerator";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox octaves;
        private System.Windows.Forms.TextBox lacurancy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amplitude;
        private System.Windows.Forms.TextBox frequency;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox level3;
        private System.Windows.Forms.TextBox level2;
        private System.Windows.Forms.TextBox level1;
        private System.Windows.Forms.TextBox level4;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.ProgressBar progr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label percval;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox seed;
        private System.Windows.Forms.Label chunkpersec;
        private System.Windows.Forms.Label timeleft;
    }
}

