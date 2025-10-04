using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class EnemyHealth : MonoBehaviour
{

    public int Health = 100;
    public GameObject DeathEffect;     
    public float effectLifeTime = 1f;  

    public void Damage(int value)
    {
        Health -= value;

        if (Health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        if (DeathEffect != null)
        {
           
            GameObject effect = Instantiate(DeathEffect, transform.position, Quaternion.identity);

           
            Destroy(effect, effectLifeTime);
        }

       
        Destroy(gameObject);
    }
}
