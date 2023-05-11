using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneLevel51 : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene("Level51");
        Time.timeScale = 1;
    }
}
