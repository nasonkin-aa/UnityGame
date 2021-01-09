using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float StartTimeBetwenSpawn;

    private float TimeBetwenSpawn;

    public GameObject[] Enumis;
    public GameObject Parent;

    private void Update()
    {
        /*Enumis[0].transform.localScale = new Vector3(40, 40, 40);
        Enumis[1].transform.localScale = new Vector3(40, 40, 40);
        Enumis[2].transform.localScale = new Vector3(40, 40, 40);
        Enumis[0].transform.SetParent(Parent.transform);
        Enumis[1].transform.SetParent(Parent.transform);
        Enumis[2].transform.SetParent(Parent.transform);*/
        if (TimeBetwenSpawn <= 0)
        {
            
            int rand = Random.Range(0, Enumis.Length);
            Instantiate(Enumis[rand], transform.position, Quaternion.identity);
            TimeBetwenSpawn = StartTimeBetwenSpawn;
        }
        else
        {
            TimeBetwenSpawn -= Time.deltaTime;
        }
        
    }
}
