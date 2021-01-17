using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookpickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.tag);
        if (other.tag == "book1")
        {
            Destroy(other.gameObject);
            if (PlayerPrefs.GetInt("questFallBooks") == 2)
            {
                PlayerPrefs.SetInt("questFallBooks", 3);
            }
        }
    }
}
