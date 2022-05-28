using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    /// <summary>
    /// A segment of music that can be played an an instrument object. 
    /// <see cref="Score"/>s are comprised of multiple parts.
    /// </summary>
    [System.Serializable]
    public class Part
    {
        public Measure[] Measures;
        public TimeSignature TimeSignature;

        public Part(int numberOfMeasures, TimeSignature timeSignature)
        {
            Measures = new Measure[numberOfMeasures];
            TimeSignature = timeSignature;

            for (int i = 0; i < Measures.Length; i++)
            {
                Measures[i] = new Measure(TimeSignature.Beats, TimeSignature.BeatLength);
            }
        }
    }
}
