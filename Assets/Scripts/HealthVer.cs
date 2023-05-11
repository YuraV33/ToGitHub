using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthVer : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public GameObject PanelDeath;
    public GameObject text;
    public void TakeHit(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
            if (!PanelDeath.activeSelf && health < 0)
            {
                PanelDeath.SetActive(true);
            }

    }
    public void SetHealth(int bonusHealth)
    {
        health += bonusHealth;
        if (health > maxHealth)
        {
            health = maxHealth; 
        }
    }
}
