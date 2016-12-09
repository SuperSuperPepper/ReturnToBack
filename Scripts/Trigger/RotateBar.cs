using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBar : MonoBehaviour {

    public float cycleTime = 2f;
    public bool isleft;
    public float officAngle = 90;
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
        int i = 1;
        while (true)
        {

            Tweener tweener1 = transform.DOLocalRotate(new Vector3(0, officAngle*i, 0), cycleTime);
          
            tweener1.SetEase(Ease.Linear);
       
            tweener1.Pause();
        
            tweener1.Play();
       
            yield return new WaitForSeconds(cycleTime * 2);
            i++;
            Debug.Log("once");
        }
    }

}
