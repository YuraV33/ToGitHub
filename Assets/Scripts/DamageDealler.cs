using UnityEngine;
public class DamageDealler : MonoBehaviour
{
    [SerializeField] private float damage1;
      private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Damadeable"))
        {
            ScoreScript.scoreValue += 0.25f; //
            collision.gameObject.GetComponent<Health>().TakeDamage(damage1);
        }
        Destroy(gameObject);
     }
}
