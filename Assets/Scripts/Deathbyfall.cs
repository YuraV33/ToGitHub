using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Deathbyfall : MonoBehaviour
{
    public GameObject PanelDeath;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Finish")
        {
            Debug.Log("Fall to Death");
            PanelDeath.SetActive(true);
        }
    }
}
