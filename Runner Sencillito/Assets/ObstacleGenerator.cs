using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject[] obstaclePrefabs; // Array de prefabs de obst�culos
    public Transform[] lanes; // Array de transformaciones que marcan los carriles
    public float spawnInterval = 2f; // Intervalo de generaci�n de obst�culos
    public float spawnOffset = 5f; // Desplazamiento de la generaci�n de obst�culos

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            GenerateObstacle();
            timer = 0f;
        }
    }

    void GenerateObstacle()
    {
        int laneIndex = Random.Range(0, lanes.Length); // Selecciona un carril aleatorio
        Vector3 spawnPosition = lanes[laneIndex].position + Vector3.forward * spawnOffset; // Calcula la posici�n de generaci�n

        GameObject obstaclePrefab = obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)]; // Selecciona un obst�culo aleatorio del array
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity); // Genera el obst�culo en la posici�n calculada
    }
}

