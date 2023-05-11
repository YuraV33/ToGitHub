using UnityEngine;
public class DamageableEntity : MonoBehaviour
{
    public GameObject HPbarPrefab;
    public Transform CanvasTransform;
    public Transform HPBarAnchor;
    public float MaxHealthPoints;
    [HideInInspector] public float HealthPoints;
    private HPBar _hpBar;
        private void Awake()
    {
        HealthPoints = MaxHealthPoints;
        var bar = Instantiate(HPbarPrefab, CanvasTransform);
        _hpBar = bar.GetComponent<HPBar>();
        _hpBar.Initialize(HPBarAnchor, this);
            }

    public void TakeDamage(float damage1)
    {
        _hpBar.UpdateBar();
         HealthPoints -= damage1;
        if (HealthPoints <= 0)
        {
            HealthPoints = 0;
            Die();
        }
     }

    public void Die()
    {
        Destroy(_hpBar.gameObject);
        Destroy(gameObject);
   }
}
