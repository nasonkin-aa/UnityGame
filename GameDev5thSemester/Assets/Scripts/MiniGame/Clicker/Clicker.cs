using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    public int Score=0;
    public float TimeStart = 3f;
    public int MaxScore=10;
    [SerializeField] private TextMesh ScoreLabel;
    [SerializeField] private TextMesh TimeLabel;

    public bool TimerCheck =false;

    public void OnMouseDown()
    {
        
        if (Score < MaxScore)
        {
            Score++; 
            TimerCheck = true;

        }
        else
        {
            TimerCheck = false;

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
    
        
    }
    public void Check()
    {
        if (TimerCheck == true)
        {
            if (TimeStart <= 0.00f)
            {
                Score = 0;
                TimeStart = 3f;
            }
            else
            {
                TimeStart -= Time.deltaTime;
                TimeLabel.text = TimeStart.ToString("F2");

            }


        }
    }
 
}
