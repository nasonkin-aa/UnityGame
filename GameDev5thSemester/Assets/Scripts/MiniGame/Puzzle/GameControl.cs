using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private Transform[] easy;

    [SerializeField]
    private GameObject done;

    public static bool youWin;
    public GameObject Zone;


    void Start()
    {
        done.SetActive(false);
        youWin = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (easy[0].rotation.z == 0 &&
            easy[1].rotation.z == 0 &&
            easy[2].rotation.z == 0 &&
            easy[3].rotation.z == 0 &&
            easy[4].rotation.z == 0 &&
            easy[5].rotation.z == 0 &&
            easy[6].rotation.z == 0 &&
            easy[7].rotation.z == 0 &&
            easy[8].rotation.z == 0)
        {
            youWin = true;
            done.SetActive(true);
        }
    }

    public void OnMouseDown()
    {

        Zone.SetActive(false);
    }
}
