using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    public GameObject obstaculos;
    public Vector2 spawnPos;
    public float delay =2f;
    public float repeatRate =2;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", delay, repeatRate);

    }

    void SpawnObstacle()
    {
        Instantiate(obstaculos, spawnPos, obstaculos.transform.rotation);

        
    }

    
}
