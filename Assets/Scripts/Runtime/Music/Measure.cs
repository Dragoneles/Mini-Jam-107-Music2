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
        public double BeatLength;

        public Measure(int beats, double beatLength)
        {
            Beats = new Beat[beats];
            BeatLength = beatLength;

            for (int i = 0; i < Beats.Length; i++)
            {
                Beats[i] = new Beat 
                { 
                    Length = BeatLength 
                };
            }
        }
    }
}