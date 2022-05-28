using System;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    /// <summary>
    /// Object responsible for reading a score and conveying time to
    /// <see cref="Performer"/>s. Helps synchronize the timing of parts.
    /// </summary>
    public class Conductor : MonoBehaviour
    {
        public delegate void ConductEventHandler(BeatIndex beatIndex);

        public event ConductEventHandler BeatConducted;

        [SerializeField]
        private Score score;

        private TimeSignature timeSignature => score.properties.TimeSignature;
        private double bpm => score.properties.BPM;
        private double beatLength => timeSignature.BeatLength;

        private BeatIndex index;

        private void Update()
        {
            
        }

        private void UpdateBeatIndex(ref BeatIndex index, double timeElapsed)
        {
            
        }

        private void ConductBeat(int measureIndex, double timeInMeasure)
        {

        }

        protected virtual void OnBeatConducted(in BeatIndex beatIndex)
        {
            BeatConducted?.Invoke(beatIndex);
        }
    }
}
