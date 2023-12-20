using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float destroyAfter = 3f;

    public float verticalValue = 1f;

    
    void Start()
    {
        Destroy(gameObject, destroyAfter);
    }


    void Update()
    {
        transform.Translate(new Vector3(0f, verticalValue) * Time.deltaTime * moveSpeed);
    }
}
