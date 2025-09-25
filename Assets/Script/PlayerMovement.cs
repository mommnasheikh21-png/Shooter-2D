using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public CharacterController2D controller;

    public int RunSpeed = 20;
    public int jump = 10;
    Rigidbody2D rb;
    public bool IsGround;
    

    [Header("Gun Settings")]
    public Transform firePoint; // <-- yahan apna child GameObject (jaise FirePoint) assign karo

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnLanding()
    {
        animator.SetBool("jump", false);
    }

    void Update()
    {
        float MoveX = Input.GetAxisRaw("Horizontal");

        // Movement
        rb.velocity = new Vector2(MoveX * RunSpeed, rb.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(MoveX));

        // Jump
        if (Input.GetKeyDown(KeyCode.UpArrow) && IsGround)
        {
            animator.SetBool("jump", true);
            rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            IsGround = false;
        }

        // Flip player & firePoint
        if (MoveX > 0) // Right
        {
            transform.localScale = new Vector3(1, 1, 1);
            firePoint.localRotation = Quaternion.Euler(0, 0, 0); // right side
        }
        else if (MoveX < 0) // Left
        {
            transform.localScale = new Vector3(-1, 1, 1);
            firePoint.localRotation = Quaternion.Euler(0, 180, 0); // left side
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsGround = true;
            animator.SetBool("jump", false);
        }
    }
    
}
