using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaundButton : MonoBehaviour
{
    public AudioSource MySound;
    public AudioClip clikSou;
    
    public void ClickSound()
    {
        MySound.PlayOneShot(clikSou);
    }
}
