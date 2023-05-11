using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneAbout : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene("About");
    }
}
