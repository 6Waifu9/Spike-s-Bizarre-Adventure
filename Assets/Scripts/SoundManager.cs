using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioPlayer;

    

   
     private void OnTriggerEnter2D(Collider2D collision) 
    {
        
        if (collision.tag == "Bone") 
        {
            
            audioPlayer.Play();
            
        }
    }
}
