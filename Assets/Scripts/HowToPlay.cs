using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HowToPlay : MonoBehaviour
{
    public GameObject howToPlayPanel;

    void Start()
    {
        howToPlayPanel.SetActive(false);
    }

    public void HowToPlayPanel()
    {
        howToPlayPanel.SetActive(true);
    }

    public void ReturnToTitle()
    {
        howToPlayPanel.SetActive(false);
    }

    
}
