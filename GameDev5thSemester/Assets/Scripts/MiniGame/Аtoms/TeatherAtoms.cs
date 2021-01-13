using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeatherAtoms : MonoBehaviour
{
    
    public StartButtonAtoms STB;
    
    public bool flag;
 

    void Update()
    {
        if (flag == true)
        {
            STB.StartButton.SetActive(true);
            STB.PressButton = false;
            flag = false;
        }

    }


}
