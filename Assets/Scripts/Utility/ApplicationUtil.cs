﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public static class ApplicationUtil
{
    public static void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}