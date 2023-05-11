using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneLevel31 : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene("Level31");
        Time.timeScale = 1;
    }
}
