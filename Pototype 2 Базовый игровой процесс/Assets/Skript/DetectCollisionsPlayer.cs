using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsPlayer : MonoBehaviour
{

    // уничтожение обекта и тригера при сталкновении  игрока 
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Game Over Player");
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
