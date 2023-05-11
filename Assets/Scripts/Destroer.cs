using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Destroer : MonoBehaviour
{
    [SerializeField] GameObject bomb;
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Lol")
        {
            bomb.gameObject.SetActive(true);
            Destroy(other.gameObject);
        }
    }
}
