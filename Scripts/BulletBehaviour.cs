using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    

    [SerializeField]
    Rigidbody rigidbody;

    [SerializeField]
    float speed = 5f;

    [SerializeField]
    int damageDealt = 1;

    



   


    //private void OnEnable()
    //{
    //    rigidbody.velocity = transform.forward * speed;
    //    lifetime = 3f;
        

    //}




    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerStatBehaviour>().TakeDamage(damageDealt);
            this.gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "Wall")
        {
            this.gameObject.SetActive(false);
        }
    }
}
