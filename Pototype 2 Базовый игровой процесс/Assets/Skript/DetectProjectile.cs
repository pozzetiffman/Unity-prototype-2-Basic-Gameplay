using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectProjectile : MonoBehaviour
{
    // уничтожение снаряда и ругого обекта при сталконовении 
    private void OnTriggerEnter(Collider other)
    {

            Destroy(gameObject);
            //Destroy(other.gameObject);


    }
}
