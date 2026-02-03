using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblesBehaviour : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;

    [SerializeField]
    float bubbleSpeed = 5f;

    private void Update()
    {
        rb.AddForce(Vector3.left * bubbleSpeed * Time.deltaTime, ForceMode.Impulse);
    }
}
