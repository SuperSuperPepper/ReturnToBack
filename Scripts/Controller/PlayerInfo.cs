using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour {
    public int maxHealth = 4;
    private int currentHealth;

   
	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Dameger(int dameger)
    {
        currentHealth -= dameger;
        if (currentHealth == 0) {
            //game over

        }
    }
    public void HealthAdd(int hp) {
        if (currentHealth == maxHealth)
        {
            Debug.Log("good");
            return;
        }
        else {
            currentHealth += hp;
            
        }
        Debug.Log(currentHealth);
    }
}
