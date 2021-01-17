using System.Collections;
using UnityEngine;

public class SpawnBooks : MonoBehaviour
{
    public GameObject book;
    public NewController newController;
    public GameObject player;
    
    public void StartSpawn()
    {
        player.SetActive(true);
        StartCoroutine(Spawn());
        gameObject.transform.SetPositionAndRotation(new Vector3(gameObject.transform.position.x + 100, gameObject.transform.position.y + 100, 100), Quaternion.identity);
    }
    IEnumerator Spawn()
    {
        while (!Player.lose)
        {
            Instantiate(book, new Vector3 (Random.Range(2.5f, 18f), 7f, 5f), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
