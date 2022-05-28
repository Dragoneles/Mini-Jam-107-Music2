using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    public record MinorKey : Key
    {
        public MinorKey(PitchName tonic) : base(tonic) { }

        public override PitchName Supertonic    => Tonic.Transpose().Up(Interval.MinorSecond);
        public override PitchName Mediant       => Tonic.Transpose().Up(Interval.MinorThird);
        public override PitchName Subdominant   => Tonic.Transpose().Up(Interval.PerfectFourth);
        public override PitchName Dominant      => Tonic.Transpose().Up(Interval.PerfectFifth);
        public override PitchName Submediant    => Tonic.Transpose().Up(Interval.MinorSixth);
        public override PitchName Subtonic      => Tonic.Transpose().Up(Interval.MinorSeventh);

        public MajorKey ToMajorKey()
        {
            var majorTonic = Tonic.Transpose().Up(Interval.MinorThird);
            return new MajorKey(majorTonic);
        }

        public override string ToString()
        {
            return $"{Tonic.Prettify()} minor";
        }
    }
}
