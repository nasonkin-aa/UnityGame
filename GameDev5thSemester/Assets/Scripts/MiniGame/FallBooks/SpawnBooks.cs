using System.Collections;
using UnityEngine;

public class SpawnBooks : MonoBehaviour
{
    public GameObject book;
    public NewController newController;
    
    public void StartSpawn()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while (!Player.lose)
        {
            Instantiate(book, new Vector3 (Random.Range(-16f, 10f), 7f, 10f), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
