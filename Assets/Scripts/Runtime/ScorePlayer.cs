using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JC.Music;

public class ScorePlayer : MonoBehaviour
{
    private static ScorePlayer _instance;
    public static ScorePlayer Instance
    {
        get => _instance;
    }

    [SerializeField]
    private Score _score;
    public static Score Score
    {
        get => Instance._score;
    }

    private void Awake()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;
    }

    private void Update()
    {
        
    }
}
