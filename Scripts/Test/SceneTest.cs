using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Global.GetInstance().SceneName = "Level1";
    }
	
	// Update is called once per frame
	void Update () {
      
        if (Input.GetKey(KeyCode.A)) {
            Debug.Log("load loading scene");
          


            SceneManager.LoadScene("Loading");

        }
	}
}
