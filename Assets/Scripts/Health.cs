using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    [SerializeField] private float damage;
    public float currentHealth;
    private bool isAlive;
    [SerializeField] public TextMeshProUGUI healthText;

    private void Awake()
    {
       isAlive = true;
    }
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        ChackIsAlive();
    }
    private void ChackIsAlive()
    {
        if (currentHealth > 0) ;
        else
        Destroy(gameObject);
    }

    public void SetHealth(float bonusHealth)
    {
        currentHealth += bonusHealth;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
        private void Update()
    {
        ChackIsAlive();
   }
}


