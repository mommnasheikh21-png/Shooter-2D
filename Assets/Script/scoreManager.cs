using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
   public static scoreManager Instance;
 
    public Text scoreText;
    private int score= 0;
    private void Awake()
    {
        if (Instance == null)Instance= this;

    }
    public void Addscore(int value)
    {

        score+=value;
        scoreText.text = "SCORE:" + score;
    }
   

}
