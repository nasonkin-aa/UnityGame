using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool lose = false;
    public GameObject restart;
    public GameObject end;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Book")
        {
            print("hhhh");
            lose = true;
            restart.SetActive(true);
            end.SetActive(true);
        }
    }

    public void Restart()
    {
        lose = false;
        restart.SetActive(false);
        end.SetActive(false);
        FindObjectOfType<SpawnBooks>().StartSpawn();
    }

    public void GameWin()
    {
        lose = true;
        print("победа");
    }
}
