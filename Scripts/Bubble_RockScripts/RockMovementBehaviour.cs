using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMovementBehaviour : MonoBehaviour
{
    [SerializeField]
    int rockSpeed = 3;

    [SerializeField]
    Rigidbody rb;

    private void Update()
    {
        rb.AddForce(Vector3.left * rockSpeed * Time.deltaTime, ForceMode.Impulse);
    }
}
