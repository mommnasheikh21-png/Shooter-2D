using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public float speed = 3.5f;
    public float leftX = -4f;
    public float rightX = 4f;
    private bool movingLeft = true;
    private SpriteRenderer sr;

    void Start()
    {
        
    }

    void Update()
    {
        if (movingLeft)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (transform.position.x <= leftX)
                TurnAround();
        }
        else
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            if (transform.position.x >= rightX)
                TurnAround();
        }
    }

    void TurnAround()
    {
        movingLeft = !movingLeft;  //
        // flip sprite horizontally
      //  if (sr != null) sr.flipX = !sr.flipX;
    }
}
