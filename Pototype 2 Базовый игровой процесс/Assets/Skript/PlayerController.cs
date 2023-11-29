using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0f;
    public float RangeX = 10f;
    public GameObject projectilePrefab;

    private void FixedUpdate()
    {


        // если позиция привевышает - RangeX новая позиция остается прежней по всем осям 
        if (transform.position.x < -RangeX)
        {
            transform.position = new Vector3(-RangeX, transform.position.y, transform.position.z);
        }

        if (transform.position.x > RangeX)
        {
            transform.position = new Vector3(RangeX, transform.position.y, transform.position.z);
        }

        float h = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * h * speed * Time.deltaTime);




    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 posY = new Vector3(transform.position.x, 0.75f, transform.position.z);

            Instantiate(projectilePrefab, posY, projectilePrefab.transform.rotation);

        }
    }



}
