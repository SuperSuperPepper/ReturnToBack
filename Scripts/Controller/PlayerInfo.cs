using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour {
    public int Health = 4;

   
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Dameger(int dameger)
    {
        Health -= dameger;
        if (Health == 0) {
            //game over

        }
    }
}
