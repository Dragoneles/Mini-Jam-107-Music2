using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeetCollider : MonoBehaviour
{
    public int ContactCount => contacts.Count;
    public bool IsGrounded => ContactCount > 0;

    private HashSet<Collider2D> contacts = new();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        contacts.Add(collision);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        contacts.Remove(collision);
    }
}
