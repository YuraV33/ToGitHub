﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneGame : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene("MainMeny");
        Time.timeScale = 1;
    }
}

