using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsHorizontalLeft : MonoBehaviour

{

    public float topBound = 18;
    

    private void Update()
    {
        // уничтожение предмета по позиции topBound на левые горизонтальные префабы
        if (transform.position.x > topBound)
        {
            Debug.Log("Game Over Left");
            Destroy(gameObject);
        }
       
    }
}