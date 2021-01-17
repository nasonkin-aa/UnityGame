using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneMouse : MonoBehaviour
{
    public bool Zone;
    void OnMouseEnter()
    {
        Zone = true;
        
    }
    void OnMouseExit()
    {
        Zone = false;
    }

    
 }
