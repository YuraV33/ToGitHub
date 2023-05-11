using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static float scoreValue = 0f;
    Text score;
    void Start()
    {
        score = GetComponent<Text>();
    }

     void Update()
    {
        score.text = " " + Mathf.Floor(scoreValue);
    }
}
