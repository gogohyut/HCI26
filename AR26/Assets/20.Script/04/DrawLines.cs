using NUnit.Framework;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class DrawLines : MonoBehaviour
{
    public LineSettings lineSetting;
    public Camera arCam;
    Dictionary<int, ARLine> lines = new Dictionary<int, ARLine>();
    ARPlaneManager aRPlaneManager;
    bool initialized = false;
    bool canDraw = false;
    bool isStarting = false;
    int lineCount = -1;
    void Awake()
    {
        aRPlaneManager = GetComponent<ARPlaneManager>();
        aRPlaneManager.planesChanged += PlaneChanged;
    }

    void PlaneChanged(ARPlanesChangedEventArgs args)
    {
        if(!initialized)
        {
            initialized = true;
        }
    }
    public void AllowDraw(bool isAllow)
    {
        if(!initialized) return;
        canDraw = isAllow;
        if(canDraw) isStarting = true;
    }
    void Update()
    {
        DrawLine();
    }
    void DrawLine()
    {
        if(!canDraw) return;

        Vector3 drawPosition = arCam.ScreenToViewportPoint(
            new Vector3(Screen.width/2, Screen.height/2, 0.2f));
        if(isStarting)
        {
            ARLine line = new ARLine(lineSetting);
            lineCount++;
            lines.Add(lineCount, line);
            line.AddNewLineRenderer(transform, drawPosition);
        }
        else
        {
            lines[lineCount].AddPoint(drawPosition);
        }
    }
}
