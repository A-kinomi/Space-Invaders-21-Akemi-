using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is the new mechanics I added to the enamies. New enamy prefabs are gernerated constantly.

public class EnemyPrefabs : MonoBehaviour
{
    
    public GameObject enemyPrefab;
    float interval;
    float time = 0f;

    void Start()
    {
        interval = 5f; 
    }

    
    void Update()
    {
        time += Time.deltaTime;
        
        if ( time > interval)
        {
            GameObject enemy = Instantiate(enemyPrefab);
            enemy.transform.position = new Vector3(0, 4, 0);

            time = 0f;
        }
       
    }
}
