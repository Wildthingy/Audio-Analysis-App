using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BeatSaberMapMaker
{
    class beatmapOutput
    {
        public struct BSEvent
        {
            float _time;
            int _type;
            int _value;
        }

        public struct BSNote
        {
            public float _time;
            public int _lineIndex;
            public int _lineLayer;
            public int _type;
            public int _cutDirection;
        }

        public struct BSObstacle
        {
            float _time;
			int _lineIndex;
			int _type;
			float _duration;
			int _width;
        }

        public string _version;
        public int[] _BPMChanges;
        public BSEvent[] _events;
        public BSNote[] _notes;
        public BSObstacle[] _obstacles;
        public int[] _bookmarks;

        public beatmapOutput(string version, int noteCount)
        {
            _version = version;
            _BPMChanges = new int[] { };
            _events = new BSEvent[] { };
            _notes = new BSNote[noteCount];
            _obstacles = new BSObstacle[] { };
            _bookmarks = new int[] { };
        }

        public void output(string difficulty)
        {
            string output = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(difficulty + ".dat", output);
        }
    }
}
