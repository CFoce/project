using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        int movementSpeed = 5;

        transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
    }
}

