using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderBoard : MonoBehaviour {
    public float cycleTime = 2f;
    public bool isleft;
    public float officX = 8.123f;
	// Use this for initialization
	void Start () {
        Slider(isleft);
    }

    public void Slider(bool isleft) {
        if (isleft)
        {
          
        }
        else {
            officX = -officX;
        }
        StartCoroutine(StartMove());

    }

    IEnumerator StartMove() {
        while (true) {
            Tweener tweener1 = transform.DOMove(new Vector3(transform.position.x + officX, transform.position.y, transform.position.z), cycleTime);
            Tweener tweener2 = transform.DOMove(new Vector3(transform.position.x , transform.position.y, transform.position.z), cycleTime);
            tweener1.SetEase(Ease.Linear);
            tweener2.SetEase(Ease.Linear);
            tweener1.Pause();
            tweener2.Pause();
            tweener1.Play();
            tweener1.OnComplete(delegate
            {
                tweener1.Pause();
                tweener2.Play();
                tweener2.OnComplete(delegate {
                  // tweener2.Pause();
                  // tweener1.Play();
                });
            });
            yield return new WaitForSeconds(cycleTime*2);
            Debug.Log("once");
        }
    }
  


}
