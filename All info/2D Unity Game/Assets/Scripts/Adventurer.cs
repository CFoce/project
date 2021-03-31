using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adventurer : MonoBehaviour
{
    public float gravityModifier;
    public float movementSpeed;
    public float jumpforce;   
    private Rigidbody2D playerRB;
    public GameObject projectilePrefab;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        //Physics2D.gravity *= gravityModifier;
        
    }


    // Update is called once per frame
    void Update()
    {
        
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
            playerRB.AddForce(Vector3.up * jumpforce, ForceMode2D.Impulse);
        }

        // Launch projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Game Over!");
        }
    }

}
