using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float horizontalInput;
    //private float turnSpeed = 25.0f;
    public float speed = 20.0f;
    public float xRange = 6.0f;
    public float jumpForce = 10;
    public float gravityModifier;
    public bool isOnGround = true;


    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity *= gravityModifier;
        playerRb = GetComponent<Rigidbody>();
        //playerRb.AddForce(Vector3.up * 1000);
    }

    // Update is called once per frame
    void Update()
    {
        // Keep the player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.left * horizontalInput * Time.deltaTime * speed);
        //transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        //jump control
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            Debug.Log("I jumped");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("ground"))
        {
            isOnGround = true;
            Debug.Log("Im on the ground");
        }
        else if (collision.gameObject.CompareTag("obstacle"))
        {
            //Player will have death animation if it collides with enemy or obstacle
        }
    }

    //attempting to push to main in gitkracken

}
