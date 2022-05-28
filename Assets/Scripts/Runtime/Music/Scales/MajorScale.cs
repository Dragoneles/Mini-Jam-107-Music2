using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    public record MajorScale : IonianScale
    {
        public MajorScale(MajorKey key) : base(key) { }
    }
}
