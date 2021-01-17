using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneFB : MonoBehaviour
{
    public Move move;
    private Transform player;

    void Start()
    {
        
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "FBPlayer")
        {
            move.ZoneActive = true;
            player = GameObject.FindGameObjectWithTag("FBPlayer").transform;
        }
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "FBPlayer")
        {
            move.ZoneActive = false;
            //player.position = new Vector3(player.position.x + ((player.position.x / (-(player.position.x))) * 3), player.position.y, player.position.z);
            if (player.position.x <= -447.1f)
            {
                player.position = new Vector3(-427, player.position.y, player.position.z);
            }
            if (player.position.x > 0)
            {
                player.position = new Vector3(player.position.x - 3f, player.position.y, player.position.z);
            }
        }
    }
}
