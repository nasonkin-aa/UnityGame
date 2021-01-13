using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneMouse : MonoBehaviour
{
    public bool Zone;
    void OnMouseEnter()
    {
        Zone = true;
        Debug.Log(Zone);
    }
    void OnMouseExit()
    {
       
        Zone = false;
        Debug.Log(Zone);
    }
    void OnMouseDown()
    {
        Debug.Log(Zone);

    }
    
 }
