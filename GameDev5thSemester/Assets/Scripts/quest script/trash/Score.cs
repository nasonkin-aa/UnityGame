using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Score :MonoBehaviour
{

    public static int scre;
  
    void Update()
    {
        if (scre >= 300)
        {
            Time.timeScale = 0;
            gameObject.SetActive(false);
            SceneManager.LoadScene("LoadScene 1");
            scre += 1;
        }
    }

    
}
