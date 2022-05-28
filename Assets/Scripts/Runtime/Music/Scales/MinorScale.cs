using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    public record MinorScale : AeolianScale
    {
        public MinorScale(MajorKey key) : base(key) { }
    }
}
