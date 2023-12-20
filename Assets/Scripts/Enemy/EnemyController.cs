﻿using System.Collections;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float minPosX;
    public float maxPosX;

    public float moveDistance = 1f;
    public float timeStep = 1f;

    bool isMovingRight = true;

    public float destroyAfter = 100f;

   
    void Start()
    {
        // Invoke repeating will be called once after timeStep (2nd parameter) amount,
        // and then repeatedly every timeStep (3rd parameter) amount
        InvokeRepeating("Move", timeStep, timeStep);

        Destroy(gameObject, destroyAfter);

    }


  

    void Move()
    {
        if (isMovingRight)
        {
            // Moving right
            Vector3 currentPos = transform.position;
            Vector3 newPos = currentPos + new Vector3(moveDistance, -0.2f);
            transform.position = newPos;

            // If aliens group reached the right-most edge, flip their direction
            if (transform.position.x >= maxPosX)
            {
                isMovingRight = false;
            }
        }
        else
        {
            // Moving left
            Vector3 currentPos = transform.position;
            Vector3 newPos = currentPos - new Vector3(moveDistance, 0.2f);
            transform.position = newPos;

            // If aliens group reached the left-most edge, flip their direction
            if (transform.position.x <= minPosX)
            {
                isMovingRight = true;
            }
        }
    }
}