using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownBooks : MonoBehaviour
{
    [SerializeField]
    private float fallSpeed = 3f;
    
    void Update()
    {
        if (transform.position.y < -10f)
        {
            Player.k += 1;
            Destroy(gameObject);
            if (Player.k == 20)
            {
                FindObjectOfType<Player>().GameWin();
            }
        }
        transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
    }

    /*void CleanMap()
    {
        gameObject.GetComponent<Player>().GameWin();
    }*/
}
