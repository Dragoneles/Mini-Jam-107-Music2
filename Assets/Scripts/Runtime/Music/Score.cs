using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    public class Score
    {
        [SerializeField]
        private ScoreInfo _scoreProperties = new ScoreInfo
        {
            Measures = 16,
            BPM = 60
        };
    }
}