using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneController : MonoBehaviour
{
    //private ScoreManager scoreManager;


    private void Start() 
    {
        //scoreManager = GameObject.Find("Canvas").GetComponent<ScoreManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        
        if (collision.tag == "Player") 
        {
            
            GameManager.Instance.boneCount += 1; 
            Destroy(gameObject);
        }
    }
}
