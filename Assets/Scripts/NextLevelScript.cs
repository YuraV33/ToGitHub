using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NextLevelScript : MonoBehaviour
{
    public GameObject PanelResult;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Finish")
        {
            PanelResult.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
