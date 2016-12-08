using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour {
    AsyncOperation async;
    Text text;
	// Use this for initialization
	void Start () {
        GameObject textobj = GameObject.Find("Text");
        text = textobj.GetComponent<Text>();
        text.text = "Loading...";
        Debug.Log(Global.GetInstance().SceneName);
        StartCoroutine(LoadScene());
     
		
	}
    /// <summary>
    /// 异步场景加载
    /// </summary>
    /// <returns></returns>
    IEnumerator LoadScene() {
        async = SceneManager.LoadSceneAsync(Global.GetInstance().SceneName);
        async.allowSceneActivation = false;
        int i = 0;
        while (i <= 100) {
            yield return new WaitForEndOfFrame();
            text.text = "Loading..." + i + "%";
            i++;
            //Debug.Log(i);
        }
        async.allowSceneActivation = true;
        Global.GetInstance().SceneName = "";


    }
}
