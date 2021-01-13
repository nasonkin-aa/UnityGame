using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomPatrol : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    Vector3 TargetPosition;
    public float speed;
    public StartButtonAtoms startButtonAtoms;


    void Start()
    {
        TargetPosition = GetRandomPosition();
        
    }
    void FixedUpdate()
    {
        if(startButtonAtoms.PressButton == true)
        {
            if ((Vector3)transform.position != TargetPosition)
            {
                transform.position = Vector3.MoveTowards(transform.position, TargetPosition, speed * Time.deltaTime);
            }
        else
            {
                TargetPosition = GetRandomPosition();
            }

        }
        
    }

    Vector3 GetRandomPosition()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        return new Vector3(randomX, randomY,0.2f);

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Atom")
        {
            startButtonAtoms.PressButton = false;
            startButtonAtoms.StartButton.SetActive(true);

        }

    }
}
