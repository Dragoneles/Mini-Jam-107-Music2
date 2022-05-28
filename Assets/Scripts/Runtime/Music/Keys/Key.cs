using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    public abstract record Key
    {
        private Dictionary<ScaleDegree, PitchName> tones = new();

        public PitchName Tonic => tones[ScaleDegree.First];
        public PitchName Supertonic => tones[ScaleDegree.Second];
        public PitchName Mediant => tones[ScaleDegree.Third];
        public PitchName Subdominant => tones[ScaleDegree.Fourth];
        public PitchName Dominant => tones[ScaleDegree.Fifth];
        public PitchName Submediant => tones[ScaleDegree.Sixth];
        public PitchName Subtonic => tones[ScaleDegree.Seventh];

        public Key(PitchName tonic)
        {
            tones.Add(ScaleDegree.None, PitchName.None);

            tones.Add(ScaleDegree.First, tonic);
            tones.Add(ScaleDegree.Second, GetSupertonic());
            tones.Add(ScaleDegree.Third, GetMediant());
            tones.Add(ScaleDegree.Fourth, GetSubdominant());
            tones.Add(ScaleDegree.Fifth, GetDominant());
            tones.Add(ScaleDegree.Sixth, GetSubmediant());
            tones.Add(ScaleDegree.Seventh, GetSubtonic());
        }

        protected abstract PitchName GetSupertonic();
        protected abstract PitchName GetMediant();
        protected virtual PitchName GetSubdominant() => Tonic.Transpose().Up(Interval.PerfectFourth);
        protected virtual PitchName GetDominant() => Tonic.Transpose().Up(Interval.PerfectFifth);
        protected abstract PitchName GetSubmediant();
        protected abstract PitchName GetSubtonic();
    }
}
