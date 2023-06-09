﻿using UnityEngine;

public sealed class HeroAttack : MonoBehaviour
{
    public Transform AttackPoint;
    public LayerMask DamageableLayerMask;
    public float Damage1;
    public float AttackRadius;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
        }
    }
    public void Attack()
    {
        var enemies = Physics2D.OverlapCircleAll(AttackPoint.position, AttackRadius, DamageableLayerMask);
        if (enemies.Length > 0)
        {
            for (int i = 0; i< enemies.Length; i++)
            {
                enemies[i].GetComponent<DamageableEntity>().TakeDamage(Damage1);
            }
        }
    }
}
