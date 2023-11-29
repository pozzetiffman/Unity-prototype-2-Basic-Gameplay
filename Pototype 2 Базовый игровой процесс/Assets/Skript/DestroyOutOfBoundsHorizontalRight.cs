using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsHorizontalRight : MonoBehaviour
{
    public float topBound = -19.25f;


    private void Update()
    {
        // уничтожение предмета по позиции topBound на правые горизонтальные префабы
        if (transform.position.x < topBound)
        {
            Debug.Log("Game Over Right");
            Destroy(gameObject);
        }

    }
}
