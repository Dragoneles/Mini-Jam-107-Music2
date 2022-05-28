using System;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    /// <summary>
    /// Object defining time rules for a piece of music.
    /// </summary>
    [System.Serializable]
    public struct TimeSignature : IEquatable<TimeSignature>
    {
        public int Beats;
        public NoteValue NoteValue;

        public double BeatLength => NoteValue.BeatLength;

        public static TimeSignature CommonTime
        {
            get
            {
                return new TimeSignature
                { 
                    Beats = 4, 
                    NoteValue = 4.0
                };
            }
        }

        public override string ToString()
        {
            return $"{Beats}/{NoteValue} time";
        }

        public override bool Equals(object obj)
        {
            if (obj is TimeSignature other)
                return Equals(other);

            return false;
        }

        public override int GetHashCode()
        {
            return Beats.GetHashCode() * 17 + NoteValue.GetHashCode() * 17;
        }

        public static bool operator ==(TimeSignature a, TimeSignature b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(TimeSignature a, TimeSignature b)
        {
            return !(a == b);
        }

        public bool Equals(TimeSignature other)
        {
            return (Beats == other.Beats) && (NoteValue == other.NoteValue);
        }
    }
}
