using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class restart : MonoBehaviour
{
    // Ye function button ke sath connect hoga
    public void PlayGame()
    {
        SceneManager.LoadScene("GamePlay"); // <-- yahan apna scene ka naam likho
    }

    // Agar quit button banana ho to
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit"); // Editor mein sirf debug show hoga
    }

}
