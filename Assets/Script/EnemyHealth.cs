using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class EnemyHealth : MonoBehaviour
{

    public int Health = 100;
    public GameObject DeathEffect;     // death animation ya particle prefab
    public float effectLifeTime = 1f;  // kitni der effect screen pe rahe

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
            // Effect ko instantiate karo
            GameObject effect = Instantiate(DeathEffect, transform.position, Quaternion.identity);

            // effect ko destroy kar do thodi der baad (short time ke liye dikhega)
            Destroy(effect, effectLifeTime);
        }

        // Enemy ko turant destroy kar do
        Destroy(gameObject);
    }
}
