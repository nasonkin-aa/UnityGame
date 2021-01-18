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


   

    public void TryAgain()
    {
        SceneManager.LoadScene("School");
    }
}
