using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class InstantiateQuestList : MonoBehaviour
{
    public TextAsset ta;
    public Dialog dialog;
    public int currentNode;
    public static bool flag = true;
    
    public GUISkin skin;

    public List<Answer> answers = new List<Answer>();

    void Start()
    {
        dialog = Dialog.Load(ta);
        skin = Resources.Load("questmanager") as GUISkin;
        UpdateAnswers();
    }

    void Update()
    {
        UpdateAnswers();
        if ((PlayerPrefs.GetInt("testMath") == 2) &&
            (PlayerPrefs.GetInt("testPhysics") == 2) &&
            PlayerPrefs.GetInt("testGeography") == 2 &&
            PlayerPrefs.GetInt("questMemory") == 3 && 
            PlayerPrefs.GetInt("questAtom") == 3 &&
            PlayerPrefs.GetInt("questNumbers") == 4 &&
            PlayerPrefs.GetInt("questFallBooks") == 4)
        {
            
            SceneManager.LoadScene("LoadScene 1");
        }
       
    }

    void UpdateAnswers()
    {
        answers.Clear();
        for (int i = 0; i < dialog.nodes[currentNode].answers.Length; i++)
        {
            if (dialog.nodes[currentNode].answers[i].QuestName == null || dialog.nodes[currentNode].answers[i].NeedQuestValue == PlayerPrefs.GetInt(dialog.nodes[currentNode].answers[i].QuestName))
                answers.Add(dialog.nodes[currentNode].answers[i]);
        }
        
    }

    void OnGUI()
    {
        if (flag)
        {
            GUI.skin = skin;
            GUI.Box(new Rect(20, Screen.height / 2 - 350, 350, 380), "", skin.box);
            GUI.Label(new Rect(60, Screen.height / 2 - 350, 310, 60), dialog.nodes[currentNode].NpcText);
            for (int i = 0; i < answers.Count; i++)
            {
                GUI.Label(new Rect(35, Screen.height / 2 - 300 + 40 * i, 360, 40), answers[i].text, skin.label);
            }
        }
    }
}