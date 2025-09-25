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
        rb.velocity = transform.right * Speed;   // bullet ko forward move karo
        Destroy(gameObject, 1f);
    }

    void OnTriggerEnter2D(Collider2D hitinfo)
    {
        if (hitinfo.CompareTag("Coin"))
        {
            return; // kuch mat karo, bullet chalti rahegi
        }
        // Agar enemy hit ho
        EnemyHealth enemy = hitinfo.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.Damage(50); // enemy ki health reduce karo
        }

        // Har haal me bullet destroy ho jaye
        Destroy(gameObject);
    }

}
