using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonAtoms : MonoBehaviour
{
    public bool PressButton = false;
    public GameObject StartButton;
    public GameObject Zone;
    public GameObject Atom;
    
    

    public void OnMouseDown()
    {
        
        Zone.SetActive(true);
        PressButton = true;
        StartButton.SetActive(false);
        Instantiate(Atom,new Vector3(-5f,0f,1f),Quaternion.identity);
        Instantiate(Atom, new Vector3(-5f, 5f, 1f), Quaternion.identity);
        Instantiate(Atom, new Vector3(0f, 0f, 1f), Quaternion.identity);
        Instantiate(Atom, new Vector3(5f, 5f, 1f), Quaternion.identity);
        Instantiate(Atom, new Vector3(3f, -3f, 1f), Quaternion.identity);
        Instantiate(Atom, new Vector3(6f, -3f, 1f), Quaternion.identity);





    }
}
