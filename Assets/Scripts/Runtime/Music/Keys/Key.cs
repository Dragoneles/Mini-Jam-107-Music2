using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    public abstract record Key
    {
        public PitchName Tonic { get; protected set; }
        public abstract PitchName Supertonic { get; }
        public abstract PitchName Mediant { get; }
        public abstract PitchName Subdominant { get; }
        public abstract PitchName Dominant { get; }
        public abstract PitchName Submediant { get; }
        public abstract PitchName Subtonic { get; }

        public Key(PitchName tonic)
        {
            Tonic = tonic;
        }
    }
}
