using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC.Music
{
    /// <summary>
    /// Extenions methods for <see cref="Beat"/>s.
    /// </summary>
    public static class NoteExtensions
    {
        /// <summary>
        /// Creates a dotted version of a note, whose beat length is 
        /// 50% longer.
        /// </summary>
        public static Note Dotted(this Note note)
        {
            note.Beats *= 1.5;
            return note;
        }
    }
}
