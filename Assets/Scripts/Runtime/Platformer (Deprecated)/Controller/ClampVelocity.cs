using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ClampVelocity : MonoBehaviour
{
    [SerializeField]
    private float maximumMagnitude = 20f;

    private new Rigidbody2D rigidbody;

    private void OnValidate()
    {
        rigidbody ??= GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (rigidbody.velocity.magnitude > maximumMagnitude)
        {
            rigidbody.velocity = rigidbody.velocity.normalized * maximumMagnitude;
        }
    }
}
