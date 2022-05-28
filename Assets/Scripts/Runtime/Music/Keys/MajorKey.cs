using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    public record MajorKey : Key
    {
        public MajorKey(PitchName tonic) : base(tonic) { }

        public override PitchName Supertonic    => Tonic.Transpose().Up(Interval.MajorSecond);
        public override PitchName Mediant       => Tonic.Transpose().Up(Interval.MajorThird);
        public override PitchName Subdominant   => Tonic.Transpose().Up(Interval.PerfectFourth);
        public override PitchName Dominant      => Tonic.Transpose().Up(Interval.PerfectFifth);
        public override PitchName Submediant    => Tonic.Transpose().Up(Interval.MajorSixth);
        public override PitchName Subtonic      => Tonic.Transpose().Up(Interval.MajorSeventh);

        public MinorKey ToMinorKey()
        {
            var minorTonic = Tonic.Transpose().Down(Interval.MinorThird);
            return new MinorKey(minorTonic);
        }

        public override string ToString()
        {
            return $"{Tonic.Prettify()} Major";
        }
    }
}
