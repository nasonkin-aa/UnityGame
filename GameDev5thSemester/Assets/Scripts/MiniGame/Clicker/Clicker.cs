using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    public int Score=0;
    public float TimeStart=10f;
    public int MaxScore=10;
    [SerializeField] private TextMesh ScoreLabel;
    [SerializeField] private TextMesh TimeLabel;

    public void OnMouseDown()
    {
        
        if (Score < MaxScore)
        {
            Score++;
            Debug.Log("123");
            ScoreLabel.text = "score" + Score;
            //ScoreClick();
            
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
        TimeStart -= Time.deltaTime;
        TimeLabel.text = TimeStart.ToString("F2");
    }
}
