using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    // reference to the original prefab to instatiate
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetButtonDown("Jump") && Time.timeScale == 1)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // We instantiate the prefab at the same position as the player,
        // since this script is on the player GameObject
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }
}
