using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Music
{

    /// <summary>
    /// Information pertaining to a score.
    /// </summary>
    public struct ScoreInfo
    {
        public event Action<ScoreInfo> Changed;

        [SerializeField]
        private int _measures;
        public int Measures
        {
            get => _measures;
            set
            {
                if (_measures == value)
                    return;

                _measures = value;
                Changed?.Invoke(this);
            }
        }

        [SerializeField]
        private int _bpm;
        public int BPM
        {
            get => _bpm;
            set
            {
                if (_bpm == value)
                    return;

                _bpm = value;
                Changed?.Invoke(this);
            }
        }

        private TimeSignature _timeSignature;
        public TimeSignature TimeSignature
        {
            get => _timeSignature;
            set
            {
                if (_timeSignature == value)
                    return;

                _timeSignature = value;
                Changed?.Invoke(this);
            }
        }
    }
}