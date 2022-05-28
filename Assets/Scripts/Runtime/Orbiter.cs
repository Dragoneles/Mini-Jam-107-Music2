using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JC.Music;

/// <summary>
/// Object that has other objects orbit around it.
/// </summary>
public class Orbiter : CelestialBody
{
    [Header("Properties")]
    [SerializeField]
    private float orbitRadius = 10f;

    [SerializeField]
    private float revolutionTime = 16f;

    private HashSet<CelestialBody> children = new();

    private void Update()
    {
        Rotate();
    }

    public void AddSatellite<T>(float angle) where T : CelestialBody
    {
        Vector2 direction = Vector2Extensions.DegreeToVector2(angle);
        Vector2 position = transform.position;

        var obj = Instantiate(
            new GameObject(nameof(T), typeof(T)),
            position: position + (direction * orbitRadius),
            rotation: Quaternion.identity,
            parent: transform
            );

        T satellite = obj.GetComponent<T>();
        satellite.MusicKey = this.MusicKey;
        children.Add(satellite);
    }

    private void Rotate()
    {
        float rate = 360f / revolutionTime * Time.deltaTime;

        transform.Rotate(0f, 0f, rate);
    }
}
