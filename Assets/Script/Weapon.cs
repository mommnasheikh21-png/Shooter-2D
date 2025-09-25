using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject BulletPrefabs;    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shoot();
        }
    }
    void shoot()
    {

        Instantiate(BulletPrefabs, firepoint.position, firepoint.rotation);

    }
}
