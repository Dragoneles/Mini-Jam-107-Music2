using System;
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

        public static string Prettify(this PitchName pitchName)
        {
            string name = Enum.GetName(typeof(PitchName), pitchName);
            string[] splitName = name.Split('_');

            string symbol =
                splitName[1] == "sharp" ? "#" :
                splitName[1] == "flat" ? "b" :
                string.Empty;

            return $"{splitName[0]}{symbol}";
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

        public static Key MinorKey(this Pitch pitch)
        {
            return new MinorKey(pitch.Name);
        }

        public static Key MinorKey(this PitchName pitchName)
        {
            return new MinorKey(pitchName);
        }
    }
}