using UnityEngine;



public class Player : MonoBehaviour
{

    public static bool lose = false;
    public GameObject[] X;
    public static int k = 0;

    public GameObject win;
    public GameObject FailGame;
    public GameObject EndZone;
    //public GameObject restart;
    //public GameObject end;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Book")
        {
            lose = true;
            Destroy();
            EndZone.SetActive(true);
            FailGame.SetActive(true);
            gameObject.SetActive(false);
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
        gameObject.SetActive(true);
        lose = false;
        FailGame.SetActive(false);
        EndZone.SetActive(false);
        FindObjectOfType<SpawnBooks>().StartSpawn();
    }

    public void GameWin()
    {
        lose = true;
        EndZone.SetActive(true);
        win.SetActive(true);
        gameObject.SetActive(false);
    }

    public void ExitPressed()
    {
        EndZone.SetActive(false);
        FailGame.SetActive(false);
    }

}
