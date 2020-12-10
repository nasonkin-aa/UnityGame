using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public const int gridRows = 2;
    public const int gridCols = 4;
    public const float offsetX = 2f;
    public const float offsetY = 2.5f;


    [SerializeField] private MemoryCard originalCard;
    [SerializeField] private Sprite[] images;
    [SerializeField] private GameObject Parent;
    [SerializeField] private TextMesh ScoreLabel;


    private MemoryCard FirstR;
    private MemoryCard SecondR;
    private int Score = 0;

    public GameObject ButtonExit;





    public bool CanReveal
    {
        get { return SecondR == null; }
    }

    public void CardRevealed(MemoryCard card)
    {

        if (FirstR == null)
        {
            FirstR = card;
        }
        else
        {
            SecondR = card;
            StartCoroutine(CheckMatch());
        }
    }
    private IEnumerator CheckMatch()
    {
        
        if (FirstR.id == SecondR.id)
        {
            Score++;
            ScoreLabel.text= "score" + Score;
        }
        else
        {
            yield return new WaitForSeconds(.5f);

            FirstR.Unreveal();
            SecondR.Unreveal();
        }
        FirstR = null;
        SecondR = null;
        if (Score == 4)
        {
            ButtonExit.SetActive(true);
        }



    }

    void Start()
    {

        ButtonExit = GameObject.Find("ButtonExit");
        ButtonExit.SetActive(false);
        Vector3 startPos = originalCard.transform.position;
        int[] numbers = { 0, 0, 1, 1, 2, 2, 3, 3 };
        numbers = ShuffleArray(numbers);
        
        for (int i =0; i<gridCols; i++)
        {
            for (int j =0;j< gridRows; j++)
            {
                MemoryCard card;
                if (i == 0 && j == 0)
                {
                    card = originalCard;
                }
                else
                {
                    card = Instantiate(originalCard) as MemoryCard;
                    card.transform.SetParent(Parent.transform);
                    card.transform.localScale = new Vector3(40, 40,40);
                }

                int index = j * gridCols + i;
                int id = numbers[index];
                card.SetCard(id, images[id]);

                
                float posX = -(offsetY * i) + startPos.x;
                float posY = -(offsetY * j) + startPos.y;
                card.transform.position = new Vector3(posX, posY, startPos.z);
            }
        }
        
    }
    private int[] ShuffleArray(int[] numbers)
    {
    
        int[] newArray = numbers.Clone() as int[];
        for (int i = 0; i < newArray.Length; i++)
        {
            int tmp = newArray[i];
            int r = Random.RandomRange(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;
    }
    

}
