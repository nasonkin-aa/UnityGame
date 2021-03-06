﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    public int Score = 0;
    public float TimeStart = 3f;
    public int MaxScore=10;
    [SerializeField] private TextMesh ScoreLabel;
    [SerializeField] private TextMesh TimeLabel;
    public GameObject Circle;
    public GameObject ButtonExit;
    public Vector3 FirstCircle = new Vector3(100f, 100f, 0);

    
    public bool TimerCheck = false;

    public void OnMouseDown()
    {
        
        if (Score < MaxScore)
        {
            Score++;
            Circle.transform.localScale += new Vector3(10f, 15f, 0);
            
        }
       
       
    }
    public void ScoreClick()
    {
        TimeStart -= Time.deltaTime;
        TimeLabel.text = Mathf.Round(TimeStart).ToString();
    }

    void Start()
    {
        TimeLabel.text = TimeStart.ToString("F2");
    }

    
     public void  FixedUpdate()

    {
        ScoreLabel.text = "score" + Score;
        Check();

        if (Score == MaxScore)
        {
            Circle.gameObject.GetComponent<Renderer>().material.color = Color.red;
            TimerCheck = false;
            ButtonExit.SetActive(true);

        }
        else if(Score > 0)
        {

            TimerCheck = true;
            
        }
       


    }
    public void Check()
    {
        if (TimerCheck == true)
        {
            if (TimeStart <= 0.00f)
            {
                Score = 0;
                TimeStart = 3f;
                Circle.transform.localScale = FirstCircle;
            }
            else
            {
                TimeStart -= Time.deltaTime;
                TimeLabel.text = TimeStart.ToString("F2");

            }


        }
    }
 
}
