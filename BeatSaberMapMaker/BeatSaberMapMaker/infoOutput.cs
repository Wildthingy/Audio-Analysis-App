using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatSaberMapMaker
{
    class infoOutput
    {
        struct customData
        {
            string[] _contributors;
            string _customEnvironment;
            string _customEnvironmentHash;
        }

        struct difficultyData
        {
            string _beatmapCharacteristicName;
            difficultyInfo[] _difficultyBeatmaps;
        }

        struct difficultyInfo
        {
            string _difficulty;
            int _difficultyRank;
            string _beatmapFilename;
            int _noteJumpMovementSpeed;
            int _noteJumpStartBeatOffset;
            customDifficultyData _customData;
        }

        struct customDifficultyData
        {
            string _difficultyLabel;
            float _editorOffset;
            float _editorOldOffset;
            string[] _warnings;
            string[] _information;
            string[] _suggestions;
            string[] _requirements;
        }

        string _version;
        string _songName;
        string _songSubName;
        string _songAuthorName;
        string _levelAuthorName;
        float _beatsPerMinute;
        float _songTimeOffset;
        bool _shuffle;
        float _shufflePeriod;
        float _previewStartTime;
        float _previewDuration;
        string _songFilename;
        string _coverImageFilename;
        string _environmentName;
        customData _customData;
        difficultyData _difficultyBeatmapSets;
    }
}
