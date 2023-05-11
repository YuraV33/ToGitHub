using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class KristalPicker : MonoBehaviour
{
    public TMP_Text KristalText;
    private float kristal = 0;
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "kristal")
        {
            kristal++;
            KristalText.text = kristal.ToString();
            Destroy(coll.gameObject);
        }
    }
}
