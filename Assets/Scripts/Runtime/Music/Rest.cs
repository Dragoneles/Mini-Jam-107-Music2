using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    [System.Serializable]
    public struct Rest
    {
        public double Beats;

        public Rest(double beats)
        {
            Beats = beats;
        }
    }
}
