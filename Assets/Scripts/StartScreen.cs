using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    
    public void StartButton()
    {
        SceneManager.LoadScene("Original Invader Screen");
        Time.timeScale = 1; //whithout this, once going back to the title and starting the game again, the screen freezes. 
    }

    public void QuitButton()
    {
        SceneManager.LoadScene("Title");
    }
}
