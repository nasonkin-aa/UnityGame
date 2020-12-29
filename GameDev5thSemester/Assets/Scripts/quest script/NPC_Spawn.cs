using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Spawn : MonoBehaviour
{
    public GameObject[] Npc;
    private int rnd;

    // Start is called before the first frame update
    void Awake()
    {
        rnd = Random.Range(0, Npc.Length);
        Instantiate(Npc[rnd], transform.position, Quaternion.identity);
    }
}
