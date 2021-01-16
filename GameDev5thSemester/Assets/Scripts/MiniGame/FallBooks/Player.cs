using UnityEngine;



public class Player : MonoBehaviour
{

    public static bool lose = false;
    public GameObject[] X;

    public GameObject win;
    public GameObject FailGame;
    public GameObject FallGame;
    //public GameObject restart;
    //public GameObject end;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Book")
        {
            lose = true;
            Destroy();
            FailGame.SetActive(true);
        }
    }

    public void Destroy()
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
        FailGame.SetActive(false);
        FindObjectOfType<SpawnBooks>().StartSpawn();
    }

    public void GameWin()
    {
        lose = true;
        win.SetActive(true);
    }

    public void ExitPressed()
    {
        FallGame.SetActive(false);
        FailGame.SetActive(false);
    }

}
