using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DragAndDrop : MonoBehaviour
{
    bool MouseDown = false;
    public ZoneMouse zoneMouse;
    void OnMouseDown()
    {
        MouseDown = true;
        
    }

    void OnMouseUp()
    {
        MouseDown = false;
        
    }
    void FixedUpdate()
    {
        Vector3 Cursor = Input.mousePosition;

        Cursor = Camera.main.ScreenToWorldPoint(Cursor);
        Cursor.z = 0.5f;

        Debug.Log(zoneMouse.Zone);
        if (zoneMouse.Zone)
        {
            if (MouseDown)
            {
                this.transform.position = Cursor;
            }
        }
        
    }

}
