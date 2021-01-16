using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InstantiateDialog : MonoBehaviour
{
    public TextAsset ta;
    public Dialog dialog;
    public int currentNode;
    public bool ShowDialogue;
    public GameObject controller;

    public GUISkin skin;

    public List<Answer> answers = new List<Answer>();

    void Start()
    {
        controller = GameObject.Find("Сontroller");
        dialog = Dialog.Load(ta);
        skin = Resources.Load("Skin") as GUISkin;
        UpdateAnswers();
    }

    void Update()
    {
        UpdateAnswers();
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
        GUI.skin = skin;
        if (ShowDialogue)
        {
            controller.SetActive(false);
            GUI.Box(new Rect(Screen.width / 2 - 640, Screen.height - 600, 1280, 690), "", skin.box);
            GUI.Label(new Rect(Screen.width / 2 - 560, Screen.height - 450, 1260, 120), dialog.nodes[currentNode].NpcText);
            for (int i = 0; i < answers.Count; i++)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - 550, Screen.height - 250 + 60 * i, 1000, 70), answers[i].text, skin.label))
                {
                    if (answers[i].QuestValue > 0)
                    {
                        PlayerPrefs.SetInt(answers[i].QuestName, answers[i].QuestValue);
                    }
                    if (answers[i].end == "true")
                    {
                        ShowDialogue = false;
                    }
                    if (answers[i].RewardPoints > 0)
                    {
                        Score.scre += answers[i].RewardPoints;
                    }
                    currentNode = answers[i].nextNode;
                    UpdateAnswers();
                }
            }
        }
        else
        {
            controller.SetActive(true);
        }
    }
}