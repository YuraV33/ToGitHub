using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CollisionDamageEnemy : MonoBehaviour
{
    public int collisionDamage = 10;
    public string collisionTag;
        private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == collisionTag)
        {
            HealthVerEnemy healthVerEnemy = coll.gameObject.GetComponent<HealthVerEnemy>();
            healthVerEnemy.TakeHit(collisionDamage);
          
        }
    }
}
