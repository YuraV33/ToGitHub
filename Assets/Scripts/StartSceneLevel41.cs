using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneLevel41 : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene("Level41");
        Time.timeScale = 1;
    }
}
