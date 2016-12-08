using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneManager : MonoBehaviour,ILevelManager {

    public Transform startPosition;
    public Transform checkPositon
    {
        get;

        set;
    }




    // Use this for initialization
    void Start () {
        checkPositon = startPosition;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public  void StartGame()
    {
    

    }

    public  void GameOver()
    {


    }

    public  void ReturnCheck()
    {


    }
}
