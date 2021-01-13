using System.Collections;
using UnityEngine;

public class SpawnBooks : MonoBehaviour
{
    public GameObject book;

    
    public void StartSpawn()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while (!Player.lose)
        {
            Instantiate(book, new Vector3 (Random.Range(-12f, 9.5f), 7f, -113f), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
