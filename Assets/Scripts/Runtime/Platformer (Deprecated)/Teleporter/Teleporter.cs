using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class Teleporter : MonoBehaviour
{
    /// <summary>
    /// Event raised whenever a teleporter is created.
    /// </summary>
    public static event Action<Teleporter> Created;

    [SerializeField]
    private UnityEvent teleportedObject = new UnityEvent();

    [SerializeField]
    [Tooltip("Teleporters with the same ID will be linked to each other.")]
    private string id = "A";

    [SerializeField]
    private Transform outputPoint;

    private Teleporter counterpart;

    private void Awake()
    {
        Created += OnAnyTeleporterCreated;
    }

    private void Start()
    {
        Created?.Invoke(this);
    }

    private void OnDestroy()
    {
        Created -= OnAnyTeleporterCreated;
    }

    private void OnValidate()
    {
        if (outputPoint == null)
            Debug.LogWarning($"{nameof(outputPoint)} of {this} must not be null.");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Teleportable teleportable))
        {
            Input(teleportable);
        }
    }

    private void Input(Teleportable target)
    {
        counterpart?.Output(target);
    }

    private void Output(Teleportable target)
    {
        target.transform.position = outputPoint.position;

        var rigidbody = target.Rigidbody;

        var incomingVector = counterpart.transform.InverseTransformVector(rigidbody.velocity);
        var outputVector = transform.TransformVector(-incomingVector);

        Debug.DrawLine(counterpart.transform.position - incomingVector, counterpart.transform.position, Color.red, 2f);
        Debug.DrawLine(transform.position, transform.position + outputVector, Color.green, 2f);

        rigidbody.velocity = outputVector;

        teleportedObject?.Invoke();
    }

    private void OnAnyTeleporterCreated(Teleporter other)
    {
        if (other == this)
            return;

        if (other.id == this.id)
            counterpart = other;
    }
}
