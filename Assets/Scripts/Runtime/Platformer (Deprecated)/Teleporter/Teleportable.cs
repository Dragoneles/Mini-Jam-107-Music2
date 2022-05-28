using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Teleportable : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public Rigidbody2D Rigidbody
    {
        get
        {
            if (_rigidbody == null)
                _rigidbody = GetComponent<Rigidbody2D>();

            return _rigidbody;
        }
    }
}
