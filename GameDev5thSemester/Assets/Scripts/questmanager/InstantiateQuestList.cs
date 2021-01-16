using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InstantiateQuestList : MonoBehaviour
{
    public TextAsset ta;
    public Dialog dialog;
    public int currentNode;

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
        GUI.Box(new Rect(20, Screen.height / 2 - 350, 350, 500), "", skin.box);
        GUI.Label(new Rect(60, Screen.height / 2 - 350, 310, 60), dialog.nodes[currentNode].NpcText);
        for (int i = 0; i < answers.Count; i++)
        {
            GUI.Label(new Rect(35, Screen.height / 2 - 300 + 40 * i, 360, 40), answers[i].text, skin.label);
        }
    }
}