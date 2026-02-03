using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatBehaviour : MonoBehaviour
{
    [SerializeField]
   public int health = 3;

    int maxHealth;

    [SerializeField]
    HealthBarBehaviour healthBar;

    [SerializeField]
    GameObject loseText;

    [SerializeField]
    GameObject loseButton;



    private void Start()
    {
        maxHealth = health;
    }


    public int GetHealth()
    {
        return health;
    }


    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;

        if (healthBar != null)
        {
            healthBar.UpdateHealthBar();
        }

        if (health <= 0)
        {
            loseText.SetActive(enabled);
            loseButton.SetActive(enabled);
            this.gameObject.SetActive(false);
            
        }

       
    }
}
