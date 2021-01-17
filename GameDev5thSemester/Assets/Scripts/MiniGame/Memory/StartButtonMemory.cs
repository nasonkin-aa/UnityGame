using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonMemory : MonoBehaviour
{
    public void OnMouseDown()
    {
        gameObject.SetActive(false);
    }
}
