using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NumEnemy : MonoBehaviour
{
    public CharNumbers charnumbers;
    public float speed;

    void Start()
    {
        charnumbers = GameObject.Find("MGBPlayer").GetComponent<CharNumbers>();

        
    }

    private void Update()
     {
        
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        
     }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("MGBPlaeyr"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
        }
        if(other.tag == gameObject.tag)
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            charnumbers.ScoreNum++;
        }
        else if(other.tag != gameObject.tag && (other.tag == "MGBFirst" || other.tag == "MGBSecond" || other.tag == "MGBThird")) 
        {
            Debug.Log("дщд");
            
        }
    }

}
