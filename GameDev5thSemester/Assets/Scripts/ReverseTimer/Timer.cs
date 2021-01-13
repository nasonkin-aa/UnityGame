using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeStart = 360f;
    public Text timer;
    public GameObject Lose;


    void Start()
    {
        timer.text = timeStart.ToString();
    }

    void Update()
    {
        if (timeStart > 0)
        {
            timeStart -= Time.deltaTime;
            timer.text = Mathf.Round(timeStart).ToString();
        }
        else
        {
            Lose.SetActive(true);
        }
    }

    public void TryAgain()
    {
        SceneManager.LoadScene("SampleScene 1");
    }
}
