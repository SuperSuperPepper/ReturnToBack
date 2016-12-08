using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnCheckPoint : MonoBehaviour {
    LevelOneManager manager;
    void Start()
    {
         manager = GameObject.Find("Level1Manager").GetComponent<LevelOneManager>();
    }

    public void OnTriggerEnter(Collider other) {

        if (other.tag == "Player") {
            Debug.Log("Player death");
            other.GetComponent<PlayerInfo>().Dameger(1);
            Rigidbody rb= other.gameObject.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            other.gameObject.transform.position = manager.checkPositon.position;

        }

    }

}
