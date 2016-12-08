using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour {
    public float smoothing = 1.0f;
    public Transform targetTrans;

    private Vector3 offset;

    // Use this for initialization
    void Start () {
        if (targetTrans == null) {
            Debug.LogError("cant find target");

        }
        offset = transform.position - targetTrans.position;
    }
	

 


    void FixedUpdate()
    {
        
        transform.position = Vector3.Lerp(transform.position, targetTrans.position + offset, Time.deltaTime * smoothing);
    }

}
