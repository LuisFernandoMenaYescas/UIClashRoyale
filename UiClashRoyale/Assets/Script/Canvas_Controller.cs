using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Controller : MonoBehaviour
{
    public Canvas canvas1;
    public Canvas controller;
    public Button cambiarCanvasButton;

    void Start()
    {
        canvas1.enabled = true;
        controller.enabled = false;

        cambiarCanvasButton.onClick.AddListener(CambiarCanvas);
    }
    void CambiarCanvas()
    {
        canvas1.enabled = false;
        controller.enabled = true;
    }
}