using System;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{
    [System.Serializable]
    public struct Beat
    {
        public event Action Played;

    }
}