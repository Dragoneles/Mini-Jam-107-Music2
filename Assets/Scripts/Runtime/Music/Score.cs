using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    [System.Serializable]
    public class Score
    {
        public ScoreInfo properties = new ScoreInfo
        {
            Measures = 16,
            BPM = 60,
            TimeSignature = TimeSignature.CommonTime,
        };

        [SerializeField]
        private HashSet<Part> parts = new();

        public void AddPart()
        {
            parts.Add(new Part(properties.Measures, properties.TimeSignature));
        }
    }
}