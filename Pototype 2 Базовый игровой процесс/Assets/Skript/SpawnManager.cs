using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnRangeX = 20;
    public float spawnPosZ = 20;
    public float startDelay = 2;
    public float spawnInterval = 1.5f;
    //public int alnimalIndex;

    private void Start()
    {
        InvokeRepeating("SpawnSpawnRandomAnimal", startDelay, spawnInterval);
    }

    private void Update()
    {
        //if (Input.GetKeyUp(KeyCode.S))
        //{
        //    SpawnSpawnRandomAnimal();
        //}
    }


    void SpawnSpawnRandomAnimal()
    {
        // рандомное колл. префаба от 0 до колл. префабов
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // позиция префаба (позиция х - рандом от (spawnRangeX до spawnRangeX), позиция y - 0, позиция z - spawnPosZ)
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        // создание префаба ( из массива по рандому, 
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform);
    }

    private void Instantiate(GameObject gameObject, Vector3 spawnPos, Transform transform)
    {
        throw new System.NotImplementedException();
    }
}


