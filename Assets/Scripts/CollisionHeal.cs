﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CollisionHeal : MonoBehaviour
{
    public int collisionHeal = 40;
    public string collisionTag;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == collisionTag)
        {
            HealthVer healthVer = coll.gameObject.GetComponent<HealthVer>();
            healthVer.SetHealth(collisionHeal);
            Destroy(gameObject);
        }
    }
}
