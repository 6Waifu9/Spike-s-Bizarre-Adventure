using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //private ScoreManager scoreManager;
    public static GameManager Instance;

    public int boneCount;

    void Awake(){
        Instance = this;
        if(Instance != null){
            //Destroy(gameObject);
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
