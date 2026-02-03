using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EndBoxBehaviour : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bubble" | collision.gameObject.tag == "Rock")
        {
            Destroy(collision.gameObject);
        }
    }

}

    
