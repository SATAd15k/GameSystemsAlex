using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    private void OnGUI() // This creates a canvas which GUI items need to be nested into in order to render
    {
        /* 
        This is a GUI element that is type "box" aka Canvas Image
        
        Creates an "image" rectangle
        first two values are starting positions and the next two are they sizes
        e.g.

        new Rect is a Canvas Rect Transform
        GUI.Box(new Rect, (Start X, Start Y, Size X, Size Y), "");

        */
        // Static Box = No NO
        // GUI.Box(new Rect(0, 0, 100, 50), "HELLO WORLD!");


        // Scaling Box by aspect ratio
        GUI.Box(new Rect(Screen.width / 16, Screen.height / 9, Screen.width / 16, Screen.width / 9), "Hello World");
    }
}
