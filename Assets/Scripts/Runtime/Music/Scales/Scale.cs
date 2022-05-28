using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    /// <summary>
    /// A stepwise arrangement of notes.
    /// </summary>
    public abstract record Scale
    {
        /// <summary>
        /// The lowest note of the scale.
        /// </summary>
        public abstract PitchName Root { get; }

        /// <summary>
        /// Number of notes in a single octave of the scale.
        /// </summary>
        public abstract int Length { get; }

        /// <summary>
        /// Scale indexer, retrieves a pitch from the scale based on how many
        /// tonal steps it is from the root.
        /// </summary>
        /// <param name="index">
        /// The desired scale degree.
        /// </param>
        /// <remarks>
        /// Note that the index has no practical bounds. For a scale with 7 
        /// pitches, an index of -3 is equivalent to 3 steps below the 
        /// root (or index 4). Likewise, index 42 would be equivalent to 
        /// index 0, the root.
        /// </remarks>
        public PitchName this[int index]
        {
            get
            {
                index %= Length;

                if (index < 0)
                    index += Length;

                throw new System.NotImplementedException();
            }
        }
    }
}
