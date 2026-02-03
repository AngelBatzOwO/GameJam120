using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableBehaviour : MonoBehaviour
{
    [SerializeField]
    OxygenBarBehaviour bar;

    [SerializeField]
    public UnityEvent OnDie;

    [SerializeField]
    OxygenBarBehaviour oxygenBar;

    void Update()
    {
        if (oxygenBar.oxygenTimer <= 0)
        {
            OnDie.Invoke();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bubble")
        {
            bar.oxygenTimer += 3.5f;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Rock")
        {
            OnDie.Invoke();
        }
    }
}
