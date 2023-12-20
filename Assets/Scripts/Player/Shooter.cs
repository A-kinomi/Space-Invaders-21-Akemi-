using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectilePrefab;

  

    void Update()
    {
        if (Input.GetButtonDown("Jump") && Time.timeScale == 1)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }
}
