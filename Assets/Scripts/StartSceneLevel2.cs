using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneLevel2 : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1;
    }
}

