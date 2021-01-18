using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    public float hours = 2;
    public float minutes = 59;
    public bool end = false;

    public Text Hour;
    public Text Minute;
    public GameObject EndPanel;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Hour.text = hours.ToString();
        Minute.text = minutes.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (end == false)
        {
            if (Mathf.Round(minutes) == 0)
            {
                if ((Mathf.Round(minutes) <= 0) && (hours == 0))
                {
                    Player.SetActive(false);
                    Time.timeScale = 0;
                    end = true;
                    EndPanel.SetActive(true);
                }
                minutes = 59;
                hours--;

            }
            else
            {
                minutes -= Time.deltaTime;
                if (Mathf.Round(minutes) / 10 >= 1)
                {
                    Hour.text = "0" + hours.ToString();
                    Minute.text = Mathf.Round(minutes).ToString();
                }
                else
                {
                    Hour.text = "0" + hours.ToString();
                    Minute.text = "0" + Mathf.Round(minutes).ToString();
                }
            }
        }
    }
}
