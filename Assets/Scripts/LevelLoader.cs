﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelLoader : MonoBehaviour
{
    public static void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }
}
