using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teather : MonoBehaviour
{
    public NumSturtButton NSB;
    public bool flag;
    public GameObject RemoveNum;
    
    void Update()
    {
        if (flag == true)
        {
            RemoveNum.SetActive(true);
            NSB.ButtonStart.SetActive(true);
            NSB.PressButton = false;
            flag = false;
        }

    }
}
