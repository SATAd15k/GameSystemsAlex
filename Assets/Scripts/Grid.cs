using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public bool toggleExample;

    void OnGUI() // This creates a canvas which GUI items need to be nested into in order to render
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


        // Scaling Box by aspect ratio defining the scale inline
        // GUI.Box(new Rect(Screen.width / 16 * 0, Screen.height / 9 * 3, Screen.width / 16 * 1, 0.5f*Screen.height / 9 * 1), "Hello World");

        // This new GUI.Box doesnt need to have width and height as well as box sizes as it has been defined globally / top level

        GUI.Box(new Rect(ScreenPlacement(2.5f, 3, 2, 4)), "helloz");
        if (toggleExample)
        {
            LessonGrid();
        }


        if (GUI.Button(new Rect(ScreenPlacement(0, 3, 1, 1)), ""))
        {
            toggleExample = !toggleExample;
        }
    }

    // This is known as a method which does not have a return type; doesnt have to give values will run top to bottom
    // void does not return a type aka null
    void LessonGrid()
    {
        /*
         Loops, For, For Each, While, Do While
        */
        // i = iteratation; default count up

        for (int x = 0; x < 16; x++)
        {
            for (int y = 0; y < 9; y++)
            {
                GUI.Box(new Rect(ScreenPlacement(x, y, 1, 1)), "");
                GUI.Label(new Rect(ScreenPlacement(x, y, 1, 1)), x + ":" + y);

            }
        }
    }
    // This is known as a function (or behavior) which has a return type; has to give something back which can be used elsewhere
    public Rect ScreenPlacement(float startPosX, float startPosY, float sizeX, float sizeY)
    {
        // Defining how Rect scaling values sit when called in other nested scripts as this is top level *GOD SCRIPT*
        Rect placement = new Rect(startPosX * Screen.width / 16, startPosY * Screen.height / 9, sizeX * Screen.width / 16, sizeY * Screen.height / 9);
        return placement;

        // In this case it will return value a new rectangle which will be defined by the values above
        return new Rect();
    }
}
