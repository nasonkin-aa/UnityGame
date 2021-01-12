using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumSturtButton : MonoBehaviour
{
    public bool PressButton = false;
    public GameObject ButtonStart;

    public void OnMouseDown()
    {
        PressButton = true;
        ButtonStart.SetActive(false);


    }

}
