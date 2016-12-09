using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeighCheck : MonoBehaviour {
    //最大速度限制
    public float MaxSpeed=20;
	// Use this for initialization
	void Start () {
		
	}

    public void OnTriggerEnter(Collider other){
        if (other.tag == "Player") {
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            Debug.Log(rb.velocity.magnitude);
            if(rb.velocity.magnitude>=MaxSpeed)
            {
                Debug.Log("dead");
            }

        }



    }
	// Update is called once per frame
	void Update () {
		
	}
}
