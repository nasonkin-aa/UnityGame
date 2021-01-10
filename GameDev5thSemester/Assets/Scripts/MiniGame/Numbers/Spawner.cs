using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float StartTimeBetwenSpawn;

    private float TimeBetwenSpawn;
    public NumSturtButton numSturtButton;
    
    
    public GameObject[] Enumis;
    public GameObject Parent;

    private void Update()
    {
        if(numSturtButton.PressButton == true){
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
        else
        {

        }
       
        
        
    }
}
