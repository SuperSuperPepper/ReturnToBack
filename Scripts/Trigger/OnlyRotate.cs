using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlyRotate : MonoBehaviour {
    public float speedX = 0;
    public float speedY =0;
    public float speedZ =0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(speedX, speedY, speedZ));
	}
}
