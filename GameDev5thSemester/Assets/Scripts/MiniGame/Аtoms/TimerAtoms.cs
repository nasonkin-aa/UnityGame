using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerAtoms : MonoBehaviour
{
    [SerializeField] private TextMesh TimeLabel;

    public StartButtonAtoms STB;

    public float TimeStart = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        if (STB.PressButton == true)
        {
            TimeStart += Time.deltaTime;
            
            TimeLabel.text = Mathf.Round(TimeStart).ToString();
            TimeLabel.text = TimeStart.ToString("F2");
        }
        else
        {
            TimeStart = 0f;
        }
   
        
    }
}
