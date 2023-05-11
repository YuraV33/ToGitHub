using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HealthVerEnemy : MonoBehaviour
{
    public int health1;
    public int maxHealth1;
    public GameObject PanelDeath;

    public void TakeHit(int damage)
    {
        health1 -= damage;
        if (health1 <= 0)
        {
            Destroy(gameObject);
        }
        if (!PanelDeath.activeSelf && health1 < 0)
        {
            PanelDeath.SetActive(true);
        }

    }
    public void SetHealth(int bonusHealth)
    {
        health1 += bonusHealth;
        if (health1 > maxHealth1)
        {
            health1 = maxHealth1;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            HealthBar_controller.instance.currentHealth -= 10;
        }
    }
}
