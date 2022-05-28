using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    /// <summary>
    /// Object that follows a conductor, reads a part, and emits notes
    /// from an instrument.
    /// </summary>
    public class Performer : MonoBehaviour
    {
        [SerializeField]
        private Conductor conductor;

        [SerializeField]
        private Instrument instrument;

        [SerializeField]
        private Part part;

        private void Awake()
        {
            conductor.BeatConducted += OnBeatConducted;
        }

        public void AssignPart(Part part)
        {
            this.part = part;
        }

        private void OnBeatConducted(BeatIndex beatIndex)
        {

        }
    }
}
