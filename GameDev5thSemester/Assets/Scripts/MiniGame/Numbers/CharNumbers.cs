using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharNumbers : MonoBehaviour
{
    public GameObject[] Projectiles;
    public sbyte Num;
  
    void Update()
    {
       
        if (Num == 1)
        {
            Instantiate(Projectiles[0], transform.position, Quaternion.identity);
            Debug.Log("ok");
            Num = 0;

        }
        else if (Num == 2)
        {
            Instantiate(Projectiles[1], transform.position, Quaternion.identity);
            Num = 0;

        }
        else if (Num == 3)
        {
            Instantiate(Projectiles[2], transform.position, Quaternion.identity);
            Num = 0;


        }
    }
    

}
