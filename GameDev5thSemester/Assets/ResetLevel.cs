using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("School");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
