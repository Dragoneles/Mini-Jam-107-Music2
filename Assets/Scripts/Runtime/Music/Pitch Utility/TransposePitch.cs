using System;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    public partial class TransposePitch
    {
        internal Pitch pitch;

        public Pitch Up(Interval interval)
        {
            int pitchIndex = (int)pitch.Name;
            int octave = pitch.Octave;

            pitchIndex += (int)interval;

            if (pitchIndex > 12)
            {
                pitchIndex -= 12;
                octave++;
            }

            return new Pitch((PitchName)pitchIndex, octave);
        }

        public Pitch Down(Interval interval)
        {
            int pitchIndex = (int)pitch.Name;
            int octave = pitch.Octave;

            pitchIndex -= (int)interval;

            if (pitchIndex < 1)
            {
                pitchIndex += 12;
                octave++;
            }

            return new Pitch((PitchName)pitchIndex, octave);
        }
    }

    public partial class TransposePitchName
    {
        internal PitchName pitchName;

        public PitchName Up(Interval interval)
        {
            int pitchIndex = (int)pitchName;

            pitchIndex += (int)interval;

            if (pitchIndex > 12)
            {
                pitchIndex -= 12;
            }

            return (PitchName)pitchIndex;
        }

        public PitchName Down(Interval interval)
        {
            int pitchIndex = (int)pitchName;

            pitchIndex += (int)interval;

            if (pitchIndex < 1)
            {
                pitchIndex += 12;
            }

            return (PitchName)pitchIndex;
        }
    }
}