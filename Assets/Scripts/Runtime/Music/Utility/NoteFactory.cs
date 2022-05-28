using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC.Music
{
    public class NoteFactory
    {
        private int dots = 0;

        protected NoteFactory()
        {
            dots = 0;
        }

        private double GetDottedNoteLength(double baseLength)
        {
            double length = baseLength;

            for (int i = 0; i < dots; i++)
            {
                baseLength *= 0.5;
                length += baseLength;
            }

            return length;
        }

        public NoteFactory Dotted
        {
            get
            {
                dots++;
                return this;
            }
        }

        public NoteLength Whole     => new(GetDottedNoteLength(4.0));
        public NoteLength Half      => new(GetDottedNoteLength(2.0));
        public NoteLength Quarter   => new(GetDottedNoteLength(1.0));
        public NoteLength Eighth    => new(GetDottedNoteLength(0.5));
        public NoteLength Sixteenth => new(GetDottedNoteLength(0.25));

        public static NoteFactory New => new NoteFactory();
    }

    public class NoteLength
    {
        private double _beats;

        public NoteLength(double beats)
        {
            _beats = beats;
        }

        public Note Note(Pitch pitch) => new Note(pitch, _beats);
        public Rest Rest() => new Rest(_beats);
    }
}
