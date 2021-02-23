using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adventurer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }


    // Update is called once per frame
    void Update()
    {
        int movementSpeed = 5;
        int jumpingSpeed = 10;

        if (Input.GetKey(KeyCode.A))
        {

            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * jumpingSpeed * Time.deltaTime);
//nice work

        }
    }
}
