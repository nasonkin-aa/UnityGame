using UnityEngine;



public class Player : MonoBehaviour
{
    public static bool lose = false;
    public GameObject[] X;
    //public GameObject restart;
    //public GameObject end;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Book")
        {
            Debug.Log("hhhh");
            lose = true;
            Destroy();
            //restart.SetActive(true);
            //end.SetActive(true);
        }
    }

    void Destroy()
    {
        X = GameObject.FindGameObjectsWithTag("Book");
        for (int i = 0; i < X.Length; i++)
        {
            Destroy(X[i]);
        }
        
    }

    public void Restart()
    {
        lose = false;
        //restart.SetActive(false);
        //end.SetActive(false);
        FindObjectOfType<SpawnBooks>().StartSpawn();
    }

    public void GameWin()
    {
        lose = true;
        print("победа");
    }
}
