using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneLevel1 : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1;
    }
}
