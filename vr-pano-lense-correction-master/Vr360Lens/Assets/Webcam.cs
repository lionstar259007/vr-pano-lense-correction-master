﻿
using UnityEngine;
using System.Linq;

public class Webcam : MonoBehaviour
{
    public WebCamTexture webcamTexture;
    // Use this for initialization
    void Start()
    {
        print(WebCamTexture.devices.Length);
        webcamTexture = new WebCamTexture();
        webcamTexture.Play();
        var render = GetComponent<Renderer>();
        if (render)
            render.material.mainTexture = webcamTexture;
    }

    void Update()
    {

    }

    // Update is called once per frame
    void OnGUI()
    {
        GUILayout.Box(webcamTexture);
    }
}
