using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global {

    public  string SceneName ="";

    private static Global _instance=null;


    //单例
    public static Global GetInstance() {
        if (_instance != null)
        {
            return _instance;
        }
        else {
            _instance = new Global();
            return _instance;
        }

    }

    public Dictionary<string, float> GameTime;

}
