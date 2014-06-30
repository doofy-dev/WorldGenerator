using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldGenerator2
{
    class statics
    {
        public static int WorldSize = 256;
        public static int WorldGenerationOctaves = 10;
        public static float WorldGenerationLacuranity = 1.85f;
        public static float WorldGenerationGain = 0.5f;
        public static float WorldGenerationAmplitude = 5.5f;
        public static float WorldGenerationFrequency = 0.0005f;

        public static string WorldSeed = "WorldGenerator";
        public static int cpdone=0;

        public static float[] levels = new float[] { 3.2f, 4, 8, 9 };
        //Blue   Yellow       Green      Grey
        public static int[,] colors = new int[4, 3] { { 0, 41, 181 }, { 224, 191, 81 }, { 0, 153, 10 }, { 166, 189, 168 } };
      //  public static int zoom = 3;
        public static Bitmap bmp;
        public static bool finished = false;
        public static float percentage;
        public static int cps = 0;
        
    }
}
