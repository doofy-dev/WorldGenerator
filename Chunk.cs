using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldGenerator2
{
    public class Chunk
    {
        public float[,] splice = new float[16, 16];
        public Chunk(int x, int y)
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++) {
                    splice[i, j] = fBm(((x * 16) + i), ((y * 16) + j), statics.WorldGenerationOctaves, statics.WorldGenerationLacuranity, statics.WorldGenerationGain);
                }
            }
        }


        private float fBm(float x, float y, int octaves, float lacunarity, float gain)
        {
            float amplitude = statics.WorldGenerationAmplitude;
            float frequency = statics.WorldGenerationFrequency;
            float sum = 0.0f;

            for (int i = 0; i < octaves; ++i)
            {
                sum += amplitude * (Math.Abs(Noise.Generate(x * frequency, y * frequency)));
                amplitude *= gain;
                frequency *= lacunarity;
            }
            return sum;
        }
       
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    s += splice[i, j] + " , ";
                }
                s += "\n";
            }
            return s;
        }
    }
}
