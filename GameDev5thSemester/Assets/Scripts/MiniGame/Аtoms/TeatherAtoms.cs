using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeatherAtoms : MonoBehaviour
{
    public bool flag;
    public GameObject Zone;
    public StartButtonAtoms STB;

    // Update is called once per frame
    void Update()
    {
        if(flag == true)
        {
            
            //STB.StartButton
            flag = false;

        }
        
    }
}
