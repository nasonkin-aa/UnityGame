using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumSturtButton : MonoBehaviour
{
    public bool PressButton = false;
    public GameObject ButtonStart;
    public GameObject RemoveNum;

    public void OnMouseDown()
    {
        PressButton = true;
        ButtonStart.SetActive(false);
        RemoveNum.SetActive(false);


    }

}
