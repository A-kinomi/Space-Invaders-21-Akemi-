using System.Collections;
using UnityEngine;

//Enamys fall down. I changed "y value" of the enemy position.
//The snow which is not shooted is destroyed after the enough time past.

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

        InvokeRepeating("Move", timeStep, timeStep);

        //snow is destroyed.
        Destroy(gameObject, destroyAfter);

    }


  

    void Move()
    {
        if (isMovingRight)
        {
            //snow move to y direction by 2.
            Vector3 currentPos = transform.position;
            Vector3 newPos = currentPos + new Vector3(moveDistance, -0.2f);
            transform.position = newPos;

            if (transform.position.x >= maxPosX)
            {
                isMovingRight = false;
            }
        }
        else
        {
            Vector3 currentPos = transform.position;
            Vector3 newPos = currentPos - new Vector3(moveDistance, 0.2f);
            transform.position = newPos;

            if (transform.position.x <= minPosX)
            {
                isMovingRight = true;
            }
        }
    }
}