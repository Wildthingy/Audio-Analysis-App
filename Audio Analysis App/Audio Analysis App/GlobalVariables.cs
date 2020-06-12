using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audio_Analysis_App
{
    public class GlobalVariables
    {
        public static int entryNo;
        public static float[] times;
        public static float[] thresholds;
        public static float[] prunedSFValues;
        public static bool[] beats;
        public static bool[] intensityChanged;
        public static int[] intensityLevel;
        public static float bpm;
        public static int numBeats;
    }
}
