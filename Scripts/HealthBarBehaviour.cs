using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehaviour : MonoBehaviour
{
    [SerializeField]
    Image healthBar;

    [SerializeField]
    PlayerStatBehaviour playerStats;

    [SerializeField]
    float maxHealth;


    void Start()
    {
        if (playerStats != null)
        {
            maxHealth = playerStats.GetHealth();
        }
    }


   public void UpdateHealthBar()
    {
        if (playerStats != null)
        {
            healthBar.fillAmount = playerStats.GetHealth() / maxHealth;
        }
    }

}
