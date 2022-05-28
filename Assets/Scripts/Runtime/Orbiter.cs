using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JC.Music;

/// <summary>
/// Object that has other objects orbit around it.
/// </summary>
public class Orbiter : MonoBehaviour
{
    [Header("Properties")]
    [SerializeField]
    private float _orbitRadius = 10f;

    [SerializeField]
    private float _revolutionTime = 16f;

    [SerializeField]
    private Phrase _phrase;
}
