using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField]
    float speed = 5f;

    [SerializeField]
    float moveInputX, moveInputY;

    [SerializeField]
    Rigidbody rigidbody;


    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveInputX = Input.GetAxis("Horizontal") / 2;
            moveInputY = Input.GetAxis("Vertical") / 2;
      
        }
        else
        {
            moveInputX = Input.GetAxis("Horizontal");
            moveInputY = Input.GetAxis("Vertical");
        }
        rigidbody.AddForce(moveInputX * speed * Time.deltaTime, 0f, moveInputY * speed * Time.deltaTime);
    }
}
