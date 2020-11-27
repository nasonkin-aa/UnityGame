using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    [SerializeField] private GameObject CardBack;
    public void OnMouseDown()
    {
        
        if (CardBack.activeSelf && controller.CanReveal)
        {

            CardBack.SetActive(false);
            controller.CardRevealed(this);
        }
    }
    public void Unreveal()
    {
        CardBack.SetActive(true);
    }

    [SerializeField] private SceneController controller;
    private int _id;
    public int id
    {
        get
        {
            return _id;
        }
    }
    public void SetCard(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }
}

