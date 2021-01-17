using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject item;
    private Transform player;
    [SerializeField] public GameObject Parent;
    private GameObject Items;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }
    public void SpawnDroppedItem()
    {
        Vector3 playerPos = new Vector3(player.position.x + 1, player.position.y - 0,5f);
        Items=Instantiate(item, playerPos, Quaternion.identity);
        
        //Items.transform.SetParent(Parent.transform);
    }
}
