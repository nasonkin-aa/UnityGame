using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText;
    public Text nameText;

    public Animator boxAnim;
    public Animator startAnim;

    public Animator Face1;
    public Animator Face2;

    private Queue<string> sentences;

    private void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        boxAnim.SetBool("boxOpen", true);
        startAnim.SetBool("startOpen", false);

        nameText.text = dialogue.name;
        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentences();
    }
    public void DisplayNextSentences()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        if (sentences.Count % 2 == 0)
        {
            dialogueText.color = new Color(0, 0, 0);
            Face1.SetBool("Face1Glow", true);
            //Face2.SetBool("Face1Glow", false);
        }


        if (sentences.Count % 2 == 1)
        {
            dialogueText.color = new Color(255, 255, 255);
            //Face1.SetBool("Face1Glow", false);
            //Face2.SetBool("Face1Glow", false);
        }

        FaceGlow();
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }
     
    IEnumerator TypeSentence(string sentence)
    {
        
        dialogueText.text = "";
        foreach( char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.1f);
        }
    }

    public void EndDialogue()
    {
        boxAnim.SetBool("boxOpen", false);
    }

    public void FaceGlow()
    {
        if (dialogueText.color == new Color(255, 255, 255))
        {
            Face1.SetBool("Face1Glow", false);
            Face2.SetBool("Face2Glow", true);
        }

        else
        {
            Face2.SetBool("Face2Glow", false);
            Face1.SetBool("Face1Glow", true);
        }
    }
}
