using System;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    [System.Serializable]
    public struct Note
    {
        public Pitch Pitch;
        public double Beats;

        public Note(Pitch pitch, double beats)
        {
            Pitch = pitch;
            Beats = beats;
        }
    }
}
