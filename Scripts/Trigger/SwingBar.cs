using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingBar : MonoBehaviour {

    public float cycleTime = 2f;
    public bool isleft;
    public float officAngle = 30;
    // Use this for initialization
    void Start()
    {

    
       Slider(isleft);
    }

    public void Slider(bool isleft)
    {
        if (isleft)
        {

        }
        else
        {
            officAngle = -officAngle;
        }
        StartCoroutine(StartMove());

    }

    IEnumerator StartMove()
    {
        while (true)
        {
            
            Tweener tweener1 = transform.DOLocalRotate(new Vector3(0, 0, officAngle), cycleTime);
            Tweener tweener2 = transform.DOLocalRotate(new Vector3(0, 0, -officAngle), 2*cycleTime);
            Tweener tweener3 = transform.DOLocalRotate(new Vector3(0, 0, 0), cycleTime);
            tweener1.SetEase(Ease.Linear);
            tweener2.SetEase(Ease.Linear);
            tweener3.SetEase(Ease.Linear);
            tweener1.Pause();
            tweener2.Pause();
            tweener3.Pause();
            tweener1.Play();
            tweener1.OnComplete(delegate
            {
                tweener1.Pause();
                tweener2.Play();
                tweener2.OnComplete(delegate {
                    tweener2.Pause();
                    tweener3.Play();
                });

            });
            yield return new WaitForSeconds(cycleTime * 4);
            Debug.Log("once");
        }
    }

}
