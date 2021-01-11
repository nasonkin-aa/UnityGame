using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teather : MonoBehaviour
{
    public NumSturtButton NSB;
    public bool flag;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == true)
        {

            NSB.ButtonStart.SetActive(true);
            NSB.PressButton = false;
            flag = false;
        }

    }
}
