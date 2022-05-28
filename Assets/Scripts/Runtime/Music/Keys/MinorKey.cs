using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    public record MinorKey : Key
    {
        public MinorKey(PitchName tonic) : base(tonic) { }

        public MajorKey ToMajorKey()
        {
            var majorTonic = Tonic.Transpose().Up(Interval.MinorThird);
            return new MajorKey(majorTonic);
        }

        public override string ToString()
        {
            return $"{Tonic.Prettify()} minor";
        }

        protected override PitchName GetMediant() => Tonic.Transpose().Up(Interval.MinorSecond);
        protected override PitchName GetSubmediant() => Tonic.Transpose().Up(Interval.MinorThird);
        protected override PitchName GetSubtonic() => Tonic.Transpose().Up(Interval.MinorSixth);
        protected override PitchName GetSupertonic() => Tonic.Transpose().Up(Interval.MinorSeventh);
    }
}
