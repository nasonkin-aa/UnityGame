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
        Instantiate(Atom,new Vector3(-16f,0f,1f),Quaternion.identity);
        Instantiate(Atom, new Vector3(-14f, 4f, 1f), Quaternion.identity);
        Instantiate(Atom, new Vector3(-5f, 1f, 1f), Quaternion.identity);
        Instantiate(Atom, new Vector3(-6f, 5f, 1f), Quaternion.identity);
        Instantiate(Atom, new Vector3(-10f, 3f, 1f), Quaternion.identity);
        Instantiate(Atom, new Vector3(-12f, 2f, 1f), Quaternion.identity);





    }
}
