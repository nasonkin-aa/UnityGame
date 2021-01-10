using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumButtonShot : MonoBehaviour
{
    public CharNumbers charNumbers;
   
    public void OnMouseDown()
    
    {
        switch (gameObject.name)
        {
            case "B1":
                {
                    charNumbers.Num = 1;
                    

                }
                break;
            case "B2":
                {
                    charNumbers.Num = 2;
                    
                }
                break;
            case "B3":
                {

                    charNumbers.Num = 3;
                }
                break;
        }

    }
}
