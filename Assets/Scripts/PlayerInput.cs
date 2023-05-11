﻿using UnityEngine;
[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(Shooter))]
public class PlayerInput : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private Shooter shooter;
    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        shooter = GetComponent<Shooter>();
    }
    private void Update()
    {
        float horizontalDirection = Input.GetAxis(GlobalStringVars.HORIZONTAL_AXIS);

        bool isJumpButtonPressed = Input.GetButtonDown(GlobalStringVars.JUMP);

        if (Input.GetButtonDown(GlobalStringVars.FIRE_1))
            shooter.Shoot(horizontalDirection);


        playerMovement.Move(horizontalDirection, isJumpButtonPressed);

        if (Input.GetAxis("Horizontal") <0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }

        if(Input.GetAxis("Horizontal") > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
