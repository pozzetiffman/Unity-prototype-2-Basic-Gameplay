using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalSpawnManagerRight : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnRangeZ = 0;
    public float spawnPosX = 0;
    public float startDelay = 2;
    public float spawnInterval = 1.5f;

    
    private void Start()
    {
        // безконечное повторения кода с функцией SpawnSpawnRandomAnimal, задержка, интервал
        InvokeRepeating("SpawnSpawnRandomAnimalHorizontal", startDelay, spawnInterval);
    }


    void SpawnSpawnRandomAnimalHorizontal()
    {
        // рандомное колл. префаба от 0 до колл. префабов
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // позиция префаба (позиция х - рандом от (spawnRangeX до spawnRangeX), позиция y - 0, позиция z - spawnPosZ)
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));

        // создание префаба ( колл. из массива по рандому, позиция, вращение) полное копирование изхрдного префаба 
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
