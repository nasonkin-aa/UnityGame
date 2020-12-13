using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest_Event : MonoBehaviour {
	public bool Quest1, Quest2, SubQuest2;
	public GameObject Quest1t, Quest2t, SubQuest2t;
    public bool end_Quest1, end_Quest2, end_SubQuest2;
    public int n = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (end_Quest1 == false)
        {
            if (Quest1 == true)
            {
                Quest1t.SetActive(true);
            }
            else
            {
                Quest1t.SetActive(false);
            }
        }
        else
        {
            Quest1t.SetActive(false);
        }
        //
        if (end_Quest2 == false)
        {
            if (Quest2 == true)
            {
                Quest2t.SetActive(true);
            }
            else
            {
                Quest2t.SetActive(false);
            }
        }
        else
        {
            Quest2t.SetActive(false);
        }
        //
        if (end_SubQuest2 == false)
        {
            if (SubQuest2 == true)
            {
                SubQuest2t.SetActive(true);
            }
            else
            {
                SubQuest2t.SetActive(false);
            }
        }
        else
        {
            SubQuest2t.SetActive(false);
        }

    }
}