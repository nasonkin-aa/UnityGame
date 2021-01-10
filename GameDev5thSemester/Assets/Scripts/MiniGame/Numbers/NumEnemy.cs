using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NumEnemy : MonoBehaviour
{
    public CharNumbers charnumbers;
    public float speed;
    public Teather teather;

    void Start()
    {
        teather = GameObject.Find("MGBController").GetComponent<Teather>();
        charnumbers = GameObject.Find("MGBPlayer").GetComponent<CharNumbers>();
    
    }

    void Update()
     {
        
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        
     }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("MGBPlaeyr"))
        {
            teather.flag=true;
            Destroy(gameObject);
        }
        if(other.tag == gameObject.tag)
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            charnumbers.ScoreNum++;
        }
        else if(other.tag != gameObject.tag && (other.tag == "MGBFirst" || other.tag == "MGBSecond" || other.tag == "MGBThird")) 
        {
            Destroy(gameObject);
            Destroy(other.gameObject);

            teather.flag = true;
        }
    }

}
