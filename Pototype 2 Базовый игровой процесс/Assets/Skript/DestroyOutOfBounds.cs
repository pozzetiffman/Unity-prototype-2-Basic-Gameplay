using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 30;
    public float lowerBound = -10;
    private GameManager gameManager;


    private void Start()
    {
        // ссылка на скрипт GameManager
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void Update()
    {
        //уничтожение предмета по позиции topBound
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        // уничтожение предмета по позиции lowerBound для вертикальных префабов
        if (transform.position.z < lowerBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);


        }

    }


}