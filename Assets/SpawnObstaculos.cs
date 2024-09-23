using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstaculos : MonoBehaviour
{
    public GameObject[] ArregleDeObstaculos;
    public Vector2 posicionSpawn;
    public float tiempoDeArranque;
    public float repeticion;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", tiempoDeArranque, repeticion);
    }

    void SpawnObstacle()
    {
        int indiceAleatorio = Random.Range(0, ArregleDeObstaculos.Length);
        GameObject obstaculoAleatorio = ArregleDeObstaculos[indiceAleatorio];
        Instantiate(obstaculoAleatorio, gameObject.transform.position, obstaculoAleatorio.transform.rotation);
    }

}
