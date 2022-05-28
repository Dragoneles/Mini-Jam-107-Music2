using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    public record MajorKey : Key
    {
        public MajorKey(PitchName tonic) : base(tonic) { }

        public MinorKey ToMinorKey()
        {
            var minorTonic = Tonic.Transpose().Down(Interval.MinorThird);
            return new MinorKey(minorTonic);
        }

        public override string ToString()
        {
            return $"{Tonic.Prettify()} Major";
        }

        protected override PitchName GetMediant() => Tonic.Transpose().Up(Interval.MajorSecond);
        protected override PitchName GetSubmediant() => Tonic.Transpose().Up(Interval.MajorThird);
        protected override PitchName GetSubtonic() => Tonic.Transpose().Up(Interval.MajorSixth);
        protected override PitchName GetSupertonic() => Tonic.Transpose().Up(Interval.MajorSeventh);
    }
}
