using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneFB : MonoBehaviour
{
    public Move move;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("FBPlayer").transform;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "FBPlayer")
        {
            move.ZoneActive = true;
            Debug.Log(move.ZoneActive);
        }
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "FBPlayer")
        {
            move.ZoneActive = false;
            Debug.Log(move.ZoneActive);
            //player.position = new Vector3(player.position.x + ((player.position.x / (-(player.position.x))) * 3), player.position.y, player.position.z);
            player.position = new Vector3(player.position.x - player.position.x / 10, player.position.y, player.position.z);
        }
    }
}
