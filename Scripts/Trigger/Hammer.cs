using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour {
    public float heght = 2;
    public float time = 2;

    private Transform father;
	// Use this for initialization
	void Start () {
        father = transform.parent;
	}
    public void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {

            Down();
        }

    }
    public void Down() {
        Tweener tween1 = father.transform.DOMove(new Vector3(transform.position.x, transform.position.y - heght, transform.position.z),time);

    }

}
