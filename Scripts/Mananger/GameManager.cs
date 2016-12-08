using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour  {


    //
    private static GameManager s_GameManager;

    public Dictionary<int, ILevelManager> leveManagerDic = new Dictionary<int, ILevelManager>();
   

    void Awake() {
        if (s_GameManager == null) {
            s_GameManager = this;
        }


    }
    public static GameManager GetInstance() {
        return s_GameManager;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape)) {
            ReturnMenu();
        }
		
	}
  
    public void LoadLevel(string level)
    {
        Global.GetInstance().SceneName = level;
        SceneManager.LoadScene("Loading");
    }

    public void ReturnMenu() {
        SceneManager.LoadScene("Menu");

    }



}
