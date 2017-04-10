using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TouchScript.Gestures;

public class Pan_Button : MonoBehaviour
{
    private float startY;

    private void Awake()
    {
        startY = transform.localPosition.y;
    }

    private void OnEnable()
    {
        GetComponent<PressGesture>().Pressed += pressedHandler;
        GetComponent<ReleaseGesture>().Released += releasedHandler;
    }

    private void OnDisable()
    {
        GetComponent<PressGesture>().Pressed -= pressedHandler;
        GetComponent<ReleaseGesture>().Released -= releasedHandler;
    }

    private void releasedHandler(object sender, EventArgs e)
    {
        transform.localPosition = new Vector3(0, startY, 0);
    }

    private void pressedHandler(object sender, EventArgs e)
    {
        transform.localPosition = new Vector3(0, startY - transform.localScale.y * .9f, 0);
    }
}
