using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDestroy : MonoBehaviour
{
   
   // public GameObject enemy;
    public Image panel;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("enemy"))
        {

            Destroy(gameObject);
            panel.gameObject.SetActive(true);
        }
    }
}
