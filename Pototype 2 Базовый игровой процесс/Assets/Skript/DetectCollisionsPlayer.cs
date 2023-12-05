using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsPlayer : MonoBehaviour
{
    private GameManager gameManager;
    

    private void Start()
    {
        // ссылка на скрипт GameManager 
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    
    private void OnTriggerEnter(Collider other)

    {
        // запуск метода кормления 
        if (other.CompareTag("Animal"))
        {
            other.GetComponent<AnimalHunger>().FeedAnimal(1);

        }

        //else if (CompareTag("Animal"))
        //{
        //    gameManager.DetectPlayer();
        //    Debug.Log("Detect");
        //}
    }
    
        
        

        //if (other.CompareTag("Player"))
        //{
        //    gameManager.AddLives(-1);
        //    //Destroy(gameObject);
        //    

        //}

        // уничтожение другого обекта и тригера при сталкновении Player с  Animal
        //if (other.CompareTag("Animal"))
        //{
        //    gameManager.AddScore(1);
        //    //Destroy(gameObject);
        //    //Destroy(other.gameObject);

        //}

    

   
}