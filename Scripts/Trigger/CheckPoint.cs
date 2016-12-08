using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

    LevelOneManager manager;
    void Start()
    {
        manager = GameObject.Find("Level1Manager").GetComponent<LevelOneManager>();
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            manager.checkPositon = transform.GetChild(0).transform;

        }
    }
	

}
