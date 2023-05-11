using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneAuther : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene("Auther");
    }
}
