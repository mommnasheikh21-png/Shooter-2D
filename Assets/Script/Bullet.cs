using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 20f;
    public Rigidbody2D rb;
   // public float distance = 10;

    void Start()
    {
        rb.velocity = transform.right * Speed;  
    }

    void OnTriggerEnter2D(Collider2D hitinfo)
    {
        if (hitinfo.CompareTag("Coin"))
        {
            return;
        }
      
        EnemyHealth enemy = hitinfo.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.Damage(50); 
        }

       
        Destroy(gameObject);
    }

}
