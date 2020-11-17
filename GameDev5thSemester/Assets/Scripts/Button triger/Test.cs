using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Button;

public class Test : MonoBehaviour
{
    public enum Number {a,b,c,d,e }
    public int h = 0;
    public GameObject[] MyObjects;
    public Number abc = Number.d;
    public Animator AnimMiniGaem;

    // Start is called before the first frame update
    void Start()
    {
        
    }
     
    // Update is called once per frame
    void Update()
    {
        /*if (heals == 100)
        {
            Debug.Log("lol");
            heals = heals-1;
            abc = Number.b;
        }*/
        
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (Button.flag == true)
        {
            switch (abc)
            {
                case Number.a:
                    {

                        AnimMiniGaem.SetTrigger("IsTriggered");
                        Debug.Log("0");
                    }
                    break;
                case Number.b:
                    {
                        AnimMiniGaem.SetTrigger("IsTriggered");
                        Debug.Log("1");
                    }
                    break;
            }
        }
        Button.flag = false;
    }
}
