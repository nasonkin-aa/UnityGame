using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharNumbers : MonoBehaviour
{
    public int ScoreNum;
    public GameObject[] Projectiles;
    public sbyte Num;
    [SerializeField] private TextMesh ScoreLabel;

    void Update()
    {
        ScoreLabel.text = "score" + ScoreNum;

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
