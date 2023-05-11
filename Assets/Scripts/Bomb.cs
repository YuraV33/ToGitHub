using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{ 
 [SerializeField] public GameObject Bomb1;
    [SerializeField] public GameObject Player1;
    [SerializeField] public GameObject Player2;
    

    private void Start()
    {
        Bomb1.gameObject.SetActive(false);
       }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name.Equals("Player1"))
        {
            Bomb1.gameObject.SetActive(true);
            PickUp();
        }
    }

    private void PickUp()
    {
        Destroy(gameObject);
    }
    } 