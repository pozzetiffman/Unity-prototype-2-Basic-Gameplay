using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // счет 
    public int score = 0;
    // жизни 
    public int lives = 3;
    public int urrentLives = 0;

    // метод жихни 
    public void AddLives(int value)
    {
        lives += value;

        if (lives <= 0)
        {
            Debug.Log("Game Over");
            lives = 0;
            

        }
        Debug.Log("Lives = " + lives);
    }

    // метот счета
    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score = " + score);
    }
    //public void DetectPlayer()
    //{
    //    if (lives <= 0)
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}




