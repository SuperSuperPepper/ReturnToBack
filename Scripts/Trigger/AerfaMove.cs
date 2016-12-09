using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AerfaMove : MonoBehaviour {
    public float offsetX=3;
    public float cycleTime=1;
    public float stepTime = 0.5f;



    private Transform[] childs;



	// Use this for initialization
	void Start () {

        //StartCoroutine(StartAerfaMove());

    }

    IEnumerator StartAerfaMove() {
        int child = transform.childCount;
        childs = new Transform[child];
        Debug.Log(child);
        while (true)
        {
           
            for (int i = 0; i < child; i++)
            {
                childs[i] = transform.GetChild(i);
                AerfaMoving(childs[i]);
                yield return new WaitForSeconds(stepTime);

            }
        }
    }

    public void OnTriggerEnter() {
        StartCoroutine(StartAerfaMove());

    }
    public void OnTriggerExit(Collider other)
    {
        StopCoroutine(StartAerfaMove());
    }

    void AerfaMoving(Transform cube) {

        Tweener tween1= cube.DOMove(new Vector3(cube.position.x , cube.position.y,cube.position.z + offsetX), cycleTime);
        Tweener tween2= cube.DOMove(new Vector3(cube.position.x , cube.position.y,cube.position.z - offsetX), cycleTime);
        Tweener tween3= cube.DOMove(new Vector3(cube.position.x , cube.position.y,cube.position.z), cycleTime);
        tween1.SetEase(Ease.Linear);
        tween2.SetEase(Ease.Linear);
        tween3.SetEase(Ease.Linear);
        tween1.Pause();
        tween2.Pause();
        tween3.Pause();

        tween1.Play();
        tween1.OnComplete(delegate {
            tween1.Pause();
            tween2.Play();
            tween2.OnComplete(delegate
            {
                tween2.Pause();
                tween3.Play();
                tween3.OnComplete(delegate
                {
                    tween3.Pause();
                    tween1.Play();
                });
            });

        });



    }
	

}
