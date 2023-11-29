using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 30;
    public float lowerBound = -10;

    private void Update()
    {
        // уничтожение предмета по позиции topBound
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        // уничтожение предмета по позиции lowerBound для вертикальных префабов
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over Top");
            Destroy(gameObject);


        }
    }
}
