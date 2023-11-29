using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40f;

    void Update()
    {
        // перемещение обекта в перед 
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
