using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatSaberMapMaker
{
    class input
    {
        internal infoOutput infoOutput
        {
            get => default(infoOutput);
            set
            {
            }
        }

        public struct intensityChange
        {
            public float time;
            public int intensityLevel;

            public intensityChange(float t, int iL)
            {
                time = t;
                intensityLevel = iL;
            }
        }

        public string songName;
        public string artistName;
        public float beatsPerMin;
        public List<float> beats;
        public List<intensityChange> intensityChanges;
    }
}
