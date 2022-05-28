using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    /// <summary>
    /// Stepwise arrangement of the seven “natural” scale degrees.
    /// </summary>
    public abstract record DiatonicScale : Scale
    {
        public override int Length => 7;
        public MajorKey Key { get; private set; }

        public PitchName Tonic => Key.Tonic;
        public PitchName Supertonic => Key.Supertonic;
        public PitchName Mediant => Key.Mediant;
        public PitchName Subdominant => Key.Subdominant;
        public PitchName Dominant => Key.Dominant;
        public PitchName Submediant => Key.Submediant;
        public PitchName Subtonic => Key.Subtonic;

        private Dictionary<int, PitchName> _scaleIndices;
        protected override Dictionary<int, PitchName> scaleIndices => throw new System.NotImplementedException();

        public DiatonicScale(MajorKey key)
        {
            Key = key;

            
        }
    }

    public record IonianScale : DiatonicScale
    {
        public IonianScale(MajorKey key) : base(key) { }

        public override PitchName Root => Tonic;
    }

    public record DorianScale : DiatonicScale
    {
        public DorianScale(MajorKey key) : base(key) { }

        public override PitchName Root => Supertonic;
    }

    public record PhrygianScale : DiatonicScale
    {
        public PhrygianScale(MajorKey key) : base(key) { }

        public override PitchName Root => Mediant;
    }

    public record LydianScale : DiatonicScale
    {
        public LydianScale(MajorKey key) : base(key) { }

        public override PitchName Root => Subdominant;
    }

    public record MixoLydianScale : DiatonicScale
    {
        public MixoLydianScale(MajorKey key) : base(key) { }

        public override PitchName Root => Dominant;
    }

    public record AeolianScale : DiatonicScale
    {
        public AeolianScale(MajorKey key) : base(key) { }

        public override PitchName Root => Submediant;
    }

    public record LocrianScale : DiatonicScale
    {
        public LocrianScale(MajorKey key) : base(key) { }

        public override PitchName Root => Subtonic;
    }

}
