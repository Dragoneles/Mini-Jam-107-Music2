using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [Header("Properties")]
    [SerializeField]
    private float accelerationMagnitude = 4f;

    [SerializeField]
    private float maxSpeed = 6f;

    [Range(0f, 1f)]
    [SerializeField]
    private float decelerationCoefficient = 0.8f;

    [SerializeField]
    private float jumpMagnitude = 12f;

    [Min(0f)]
    [SerializeField]
    private float notMovingEpsilon = 0.1f;

    private Vector2 moveDirection = new Vector2();

    [Header("Component References")]
    [SerializeField] private new Rigidbody2D rigidbody;
    [SerializeField] private Animator animator;
    [SerializeField] private FeetCollider feetCollider;

    private void OnValidate()
    {
        rigidbody ??= GetComponent<Rigidbody2D>();
        animator ??= GetComponentInChildren<Animator>();
        feetCollider ??= GetComponentInChildren<FeetCollider>();
    }

    private void Update()
    {
        UpdateAnimator();
    }

    private void FixedUpdate()
    {
        ApplyMovement();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.canceled)
            moveDirection = Vector2.zero;
        else
        {
            moveDirection = context.ReadValue<Vector2>();
            moveDirection.y = 0f;
            moveDirection.Normalize();
        }
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed)
            Jump();
    }

    private void ApplyMovement()
    {
        float xVelocityMagnitude = Mathf.Abs(rigidbody.velocity.x);

        if (moveDirection == Vector2.zero)
        {
            // decelerate
            Vector2 velocityAfterDeceleration = rigidbody.velocity;
            velocityAfterDeceleration *= decelerationCoefficient;
            velocityAfterDeceleration.y = rigidbody.velocity.y;

            rigidbody.velocity = velocityAfterDeceleration;
        }

        if (xVelocityMagnitude < maxSpeed)
        {
            // accelerate
            Vector2 acceleration = moveDirection * accelerationMagnitude;
            rigidbody.AddForce(acceleration);

            float facingDirection = rigidbody.velocity.x > 0f ? 1f : -1f;
            transform.localScale = new Vector2(facingDirection, 1f);
        }
    }

    private void Jump()
    {
        if (!feetCollider.IsGrounded)
            return;

        Vector2 jumpForce = Vector2.up * jumpMagnitude;
        rigidbody.AddForce(jumpForce, ForceMode2D.Impulse);

        animator.SetTrigger("Jump");
    }

    private void UpdateAnimator()
    {
        float xVelocityMagnitude = Mathf.Abs(rigidbody.velocity.x);

        bool isMoving = xVelocityMagnitude > notMovingEpsilon;
        animator.SetBool("IsMoving", isMoving);

        float moveScalar = xVelocityMagnitude / maxSpeed;
        animator.SetFloat("MoveAnimationScalar", moveScalar);

        animator.SetBool("IsGrounded", feetCollider.IsGrounded);
    }
}
