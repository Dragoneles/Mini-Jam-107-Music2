using System;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    /// <summary>
    /// Notes by their 12-tone scale names. Notes with different names
    /// but identical frequencies have the same index.
    /// </summary>
    public enum PitchName
    {
        None = 0,

        A_natural = 1,
        A_sharp = 2,
        B_flat = 2,
        B_natural = 3,
        B_sharp = 4,
        C_flat = 3,
        C_natural = 4,
        C_sharp = 5,
        D_flat = 5,
        D_natural = 6,
        D_sharp = 7,
        E_flat = 7,
        E_natural = 8,
        E_sharp = 9,
        F_flat = 8,
        F_natural = 9,
        F_sharp = 10,
        G_flat = 10,
        G_natural = 11,
        G_sharp = 12,
        A_flat = 12
    }

    [Serializable]
    public struct Pitch
    {
        public PitchName Name;
        public int Octave;

        public Pitch(PitchName name, int octave = 4)
        {
            Name = name;
            Octave = octave;
        }

        public override string ToString()
        {
            string name = Enum.GetName(typeof(PitchName), Name);
            string[] splitName = name.Split('_');

            string symbol =
                splitName[1] == "sharp" ? "#" :
                splitName[1] == "flat" ? "b" :
                splitName[1] == "natural" ? "nat" : 
                default;

            return $"{splitName[0]}{symbol} {Octave}";
        }
    }
}