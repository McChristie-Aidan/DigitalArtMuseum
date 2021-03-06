﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            ReloadCurrentScene();
        }

        if(Input.GetKeyDown(KeyCode.Alpha0))
        {
            LoadScene2A();
        }

        if(Input.GetKeyDown(KeyCode.Alpha9))
        {
            LoadScene2B();
        }
    }

    void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void LoadScene2A()
    {
        SceneManager.LoadScene("Test2A");
    }

    void LoadScene2B()
    {
        SceneManager.LoadScene("Test2B");
    }
}
