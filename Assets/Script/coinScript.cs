using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinScript : MonoBehaviour
{
    public int coin = 10;
   // public GameObject enemy;
   // public Image panel;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
           
            scoreManager.Instance.Addscore(coin);

            Destroy(gameObject);
        }
       
    }


}
