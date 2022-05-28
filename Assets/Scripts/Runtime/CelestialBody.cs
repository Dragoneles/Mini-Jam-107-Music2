using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JC.Music;

public abstract class CelestialBody : MonoBehaviour
{
    [field: SerializeField]
    public Key MusicKey { get; set; }
}
