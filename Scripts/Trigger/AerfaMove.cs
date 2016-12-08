using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Aerfa : MonoBehaviour {
    public float offsetX=3;



    private Transform[] childs;



	// Use this for initialization
	void Start () {
        int child = transform.childCount;
        childs = new Transform[child];
        Debug.Log(child);
        for (int i = 0; i <child; i++) {
            childs[i] = transform.GetChild(i);
          
        }
        //AerfaMove(childs[1]);
    
	}

    public void OnTriggerEnter() {


    }

    void AerfaMove(Transform cube) {
        cube.DOMove(new Vector3(cube.position.x + offsetX, cube.position.y,cube.position.z), 2f);

    }
	

}
