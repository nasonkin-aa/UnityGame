using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownBooks : MonoBehaviour
{
    [SerializeField]
    private float fallSpeed = 3f;
    int k;
    
    void Update()
    {
        if (transform.position.y < -7f)
        {
            Destroy(gameObject);
            k++;
            if (k == 1)
            {
                FindObjectOfType<Player>().GameWin();
                FindObjectOfType<Player>().Destroy();
            }
        }
        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
    }

    /*void CleanMap()
    {
        gameObject.GetComponent<Player>().GameWin();
    }*/
}
