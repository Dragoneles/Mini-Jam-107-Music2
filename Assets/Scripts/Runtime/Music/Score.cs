using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    public class Score
    {
        [SerializeField]
        private ScoreInfo _scoreProperties = new ScoreInfo
        {
            Measures = 16,
            BPM = 60
        };

        void MakeNotes()
        {
            var note1 = NoteFactory.New.Dotted.Eighth.Note(new Pitch(PitchName.F_natural));
            var rest = NoteFactory.New.Whole.Rest();
            var note2 = NoteFactory.New.Dotted.Dotted.Half.Note(new Pitch(PitchName.C_natural));
        }
    }
}