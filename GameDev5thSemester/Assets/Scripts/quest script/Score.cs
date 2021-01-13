using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score :MonoBehaviour
{

    public static int scre;
    public static GUIStyle razmer;

    void Start()
    {
        razmer = new GUIStyle();

        razmer.fontSize = 30;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(1030, 40, 100, 100), "Score: " + scre, razmer);
    }

    static void Update()
    {
        
    }
}
