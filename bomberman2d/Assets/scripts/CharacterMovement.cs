using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    [SerializeField] float speed;
    private Rigidbody2D rb;
    private Vector2 movement;
    private Animator animator;
    private bool facingRight;
    private SpriteRenderer spriteR;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteR = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
         movement.x = Input.GetAxisRaw("Horizontal") * speed;
         movement.y = Input.GetAxisRaw("Vertical") * speed;

         animator.SetFloat("Horizontal", movement.x);
         animator.SetFloat("Vertical", movement.y);
         animator.SetFloat("speed", movement.sqrMagnitude);

        if (movement.x > 0)
        {
            spriteR.flipX = true;
        }

        if (movement.x < 0)
        {
            spriteR.flipX = false;
        }
        

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }


}

