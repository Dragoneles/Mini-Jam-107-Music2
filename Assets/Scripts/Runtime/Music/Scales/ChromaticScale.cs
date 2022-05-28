using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    /// <summary>
    /// 12-note scale consisting of only half-steps.
    /// </summary>
    public record ChromaticScale : Scale
    {
        public override int Length => 12;

        private PitchName _root;
        public override PitchName Root => _root;

        public ChromaticScale(PitchName root = PitchName.A_natural)
        {
            _root = root;
        }

        public void ChangeRoot(PitchName root)
        {
            _root = root;
        }
    }
}
