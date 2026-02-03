using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;

    [SerializeField]
    float sinkSpeed = 30f;

    [SerializeField]
    float swimSpeed = 4f;

    [SerializeField]
    float floatSpeed = 40f;

    [SerializeField]
    float movementX;

    void Update()
    {
        movementX = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.Space))
        {
            PlayerFloat();
        }
        else
        {
            SinkPlayer();
        }

            
        PlayerSwim();
    }

    void SinkPlayer()
    {
        rb.AddForce(Vector3.down * sinkSpeed * Time.deltaTime, ForceMode.Impulse);
       
    }

    void PlayerFloat()
    {
        rb.AddForce(Vector3.up * floatSpeed * Time.deltaTime, ForceMode.Impulse);
    }

    void PlayerSwim()
    {
        
        rb.AddForce(movementX * swimSpeed * Time.deltaTime, 0f, 0f,ForceMode.Impulse);
    }
}
