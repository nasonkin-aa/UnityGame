using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharNumbers : MonoBehaviour
{
    public GameObject[] Projectiles;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(Projectiles[0], transform.position, Quaternion.identity);

        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(Projectiles[1], transform.position, Quaternion.identity);


        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(Projectiles[2], transform.position, Quaternion.identity);


        }
    }

}
