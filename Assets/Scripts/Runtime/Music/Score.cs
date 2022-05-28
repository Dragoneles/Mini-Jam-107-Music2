using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    public class Score
    {
        [SerializeField]
        private ScoreInfo scoreProperties = new ScoreInfo
        {
            Measures = 16,
            BPM = 60
        };

        [SerializeField]
        private HashSet<Part> parts = new();

        public void AddPart()
        {
            parts.Add(new Part(scoreProperties.Measures, scoreProperties.TimeSignature));
        }
    }
}