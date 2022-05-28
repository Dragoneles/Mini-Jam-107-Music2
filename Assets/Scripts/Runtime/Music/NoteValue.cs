using System;

namespace JC.Music
{
    [System.Serializable]
    public struct NoteValue : IEquatable<NoteValue>
    {
        public double Divisor;

        public double BeatLength
        {
            get => (4.0 / Divisor);
        }

        public bool Equals(NoteValue other)
        {
            return (Divisor == other.Divisor);
        }

        public override bool Equals(object obj)
        {
            if (obj is NoteValue other)
                return Equals(other);

            return false;
        }

        public override int GetHashCode()
        {
            return Divisor.GetHashCode() * 17;
        }

        public static bool operator ==(NoteValue a, NoteValue b)
        {
            return (a.Divisor == b.Divisor);
        }

        public static bool operator !=(NoteValue a, NoteValue b)
        {
            return !(a == b);
        }

        public static implicit operator NoteValue(double value)
        {
            return new NoteValue { Divisor = value };
        }
    }
}
