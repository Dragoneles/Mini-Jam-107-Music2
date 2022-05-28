using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    public static class PitchExtensions
    {
        public static TransposePitch Transpose(this Pitch pitch)
        {
            return Music.Transpose.Pitch(pitch);
        }

        public static TransposePitchName Transpose(this PitchName pitch)
        {
            return Music.Transpose.Pitch(pitch);
        }

        public static Pitch ToPitch(this PitchName pitchName, int octave)
        {
            return new Pitch(pitchName, octave);
        }

        public static Key MajorKey(this Pitch pitch)
        {
            return new MajorKey(pitch.Name);
        }

        public static Key MajorKey(this PitchName pitchName)
        {
            return new MajorKey(pitchName);
        }
    }
}