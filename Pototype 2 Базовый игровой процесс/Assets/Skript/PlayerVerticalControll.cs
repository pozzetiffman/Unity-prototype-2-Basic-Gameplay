using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVerticalControll : MonoBehaviour
{
    public float speedVertical = 20f;
    public float RangeZdown = 13f;
    public float RangeZup = 3.5f;

    private void FixedUpdate()
    {
        // если обект меньше по кооденате z возвразает его на позицию -RangeZdown
        if (transform.position.z < -RangeZdown)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -RangeZdown);
        }
        // если обект больше по кооденате z возвразает его на позицию -RangeZdown
        if (transform.position.z > RangeZup)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, RangeZup);
        }

        // передвижение по вертикали 
        float v = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * v * speedVertical * Time.deltaTime);
    }
}
