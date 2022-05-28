using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    public static class Transpose
    {
        private static TransposePitch transpose = new();
        private static TransposePitchName transposeByName = new();

        public static TransposePitch Pitch(Pitch pitch)
        {
            transpose.pitch = pitch;
            return transpose;
        }

        public static TransposePitchName Pitch(PitchName pitchName)
        {
            transposeByName.pitchName = pitchName;
            return transposeByName;
        }
    }
}