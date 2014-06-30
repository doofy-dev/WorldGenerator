using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldGenerator2
{
    class Generate
    {
        public void startGeneration(){
          
            for (int chx = 0; chx < statics.WorldSize; chx++)
            {
               // Console.WriteLine("X: " + chx);
                for (int chy = 0; chy < statics.WorldSize; chy++)
                {
                    statics.cpdone++;
                    Chunk c = new Chunk(chx, chy);
                    for (int x = 0; x < 16; x++)
                    {
                        for (int y = 0; y < 16; y++)
                        {
                            float Height = c.splice[x, y];
                            int[] color = colorize(Height);
                            statics.bmp.SetPixel(chx * 16 + x, chy * 16 + y, Color.FromArgb(255, color[0], color[1], color[2]));
                       
                        }
                    }
                }
                statics.cps++;
                statics.percentage = (chx/(float)(statics.WorldSize))*100;
             //   Console.WriteLine( ((chx/(float)(statics.WorldSize))).ToString());
            }
            statics.finished = true;
            
        }


        private int[] colorize(float level)
        {
            float correctionFactor;
            int[] color = new int[3];
            // Console.WriteLine(statics.levels.Length);
            for (int i = 0; i < statics.levels.Length; i++)
            {

                if (level <= statics.levels[i])
                {
                    correctionFactor = (level / 3) / statics.levels[i];
                    color = darken(new int[3] { statics.colors[i, 0], statics.colors[i, 1], statics.colors[i, 2] }, correctionFactor);
                    return color;
                }
                //Console.WriteLine(level);
            }

            correctionFactor = (level / 2) / statics.levels[3];
            color = darken(new int[3] { 255, 255, 255 }, correctionFactor);
            return color;
        }

        private int[] darken(int[] color, float correctionFactor)
        {
            float red = (float)color[0];
            float green = (float)color[1];
            float blue = (float)color[2];

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return new int[3] { (int)red, (int)green, (int)blue };
        }
    }
}
