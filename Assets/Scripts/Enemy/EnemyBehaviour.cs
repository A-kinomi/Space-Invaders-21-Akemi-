using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from here original
using UnityEngine.UI;
using TMPro;

public class EnemyBehaviour : MonoBehaviour
{
    public AudioClip destructionSFX;
    public GameObject scoreText; //challenge!

    private void Start()
    {
        scoreText = GameObject.Find("ScoreText");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print("I'm hit!");

		
        if (collision.tag == "PlayerProjectile")
        {
			
            AudioSource.PlayClipAtPoint(destructionSFX, Vector3.zero);

            // Destroy the alien game object
            Destroy(gameObject);

            // Destroy the projectile game object
            Destroy(collision.gameObject);

            scoreText.GetComponent<ScoreCount>().score = scoreText.GetComponent<ScoreCount>().score + 1;


        }
    }

    
    
}
