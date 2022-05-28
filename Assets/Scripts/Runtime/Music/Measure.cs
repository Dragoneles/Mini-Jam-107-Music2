using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    [System.Serializable]
    public struct Measure
    {
        public int NumberOfBeats => Beats.Length;
        public Beat Downbeat => Beats[0];
        public Beat[] Beats;
    }
}