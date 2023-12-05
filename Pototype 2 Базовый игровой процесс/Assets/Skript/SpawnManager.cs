using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnRangeX = 0;
    public float spawnPosZ = 0;
    public float startDelay = 2;
    public float spawnInterval = 1.5f;
    public int tes = 2;
    

    private void Start()
    {

        // безконечное повторения кода с функцией SpawnSpawnRandomAnimal, задержка, интервал
        InvokeRepeating("SpawnSpawnRandomAnimal", startDelay, spawnInterval);
    }


    void SpawnSpawnRandomAnimal()
    {
        // рандомное колл. префаба от 0 до колл. префабов
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // позиция префаба (позиция х - рандом от (spawnRangeX до spawnRangeX), позиция y - 0, позиция z - spawnPosZ)
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnPosZ), 0, spawnRangeX);

        // создание префаба ( колл. из массива по рандому, позиция, вращение) полное копирование изхрдного префаба 
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}


