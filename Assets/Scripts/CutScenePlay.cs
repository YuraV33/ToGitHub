using System.Collections;
using UnityEngine;
public class CutScenePlay : MonoBehaviour
{
    public GameObject Player;
    public float invoke_delay = 22f;
    void Update()
    {
        if (Input.GetButtonDown(GlobalStringVars.FIRE_1))
                 Dooom();
 }
        void Dooom()
        {
            Player.SetActive(true);
            Invoke("Dooom()",invoke_delay);
        }
    }


