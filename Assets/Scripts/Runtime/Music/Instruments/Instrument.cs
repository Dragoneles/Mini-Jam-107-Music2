using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    /// <summary>
    /// Object capable of playing notes.
    /// </summary>
    public abstract class Instrument : MonoBehaviour
    {
        public abstract void AssignPart(ref Part part);
        public abstract void PlayNote(ref Note note, double duration);
    }
}
