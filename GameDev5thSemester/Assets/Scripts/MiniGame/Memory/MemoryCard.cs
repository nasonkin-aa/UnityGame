﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    [SerializeField] private GameObject CardBack;
    public void OnMouseDown()
    {
        if (CardBack.activeSelf)
        {
            CardBack.SetActive(false);
        }
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

