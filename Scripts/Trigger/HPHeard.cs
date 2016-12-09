using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPHeard : MonoBehaviour {
    public int hp = 1;

	// Use this for initialization
	void Start () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            Debug.Log("enter");
            other.gameObject.GetComponent<PlayerInfo>().HealthAdd(hp);
        }
    }
}
