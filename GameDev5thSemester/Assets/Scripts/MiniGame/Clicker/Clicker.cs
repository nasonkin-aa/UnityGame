using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    public int Score=0;
    public float Time=0f;
    public int MaxScore=10;


    private void OnMouseDown()
    {
        if (MaxScore < 10)
        {
            Score++;
        }
        
    }
    private IEnumerator CheckMatch(int Score)
    {
        Score++;
        //return Score;
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
