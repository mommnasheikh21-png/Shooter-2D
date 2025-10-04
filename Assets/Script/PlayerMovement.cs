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
    public Transform firePoint; 
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

       
        rb.velocity = new Vector2(MoveX * RunSpeed, rb.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(MoveX));

       
        if (Input.GetKeyDown(KeyCode.UpArrow) && IsGround)
        {
            animator.SetBool("jump", true);
            rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            IsGround = false;
        }

       
        if (MoveX > 0) 
        {
            transform.localScale = new Vector3(1, 1, 1);
            firePoint.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (MoveX < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            firePoint.localRotation = Quaternion.Euler(0, 180, 0); 
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
