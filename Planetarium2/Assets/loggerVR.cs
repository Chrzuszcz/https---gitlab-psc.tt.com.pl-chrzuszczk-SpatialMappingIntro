﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loggerVR : MonoBehaviour {

    TextMesh textMesh;
    // Use this for initialization
    void Start () {
        textMesh = gameObject.GetComponentInChildren<TextMesh>();
    }

    void OnEnable()
    {
        Application.logMessageReceived += LogMessage;
    }

    void OnDisable()
    {
        Application.logMessageReceived -= LogMessage;
    }

    public void LogMessage(string message, string stackTrace, LogType type)
    {
        if (textMesh.text.Length > 300)
        {
            textMesh.text = "\n" + message ;
        }
        else
        {
            textMesh.text += "\n" + message;
        }
    }
}
