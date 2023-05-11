
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HealthBar_controller : MonoBehaviour
{
    public Image healthBarImage;
    public float currentHealth;
    public float maxHealth;
    public TextMeshProUGUI healthText;
    public GameObject Backdround;
    public GameObject Bar;
    public GameObject Bar1;
    public static HealthBar_controller instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
   
    void Update()
    {
        BarSystem();
        Die();
    }
    public void BarSystem()
    {
        healthBarImage.fillAmount = currentHealth / maxHealth;
        healthText.text = maxHealth + "/" + currentHealth;

        if (currentHealth <= 0)
        {
            currentHealth = 0;
        }
        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth; 
        }
    }
    public void Die()
    {
        if(currentHealth <=9)
        {
            this.gameObject.SetActive(false);
            Backdround.gameObject.SetActive(false);
            Bar.gameObject.SetActive(false);
            Bar1.gameObject.SetActive(false);
        }
    }
}
