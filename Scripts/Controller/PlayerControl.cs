using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerControl : MonoBehaviour {
    //speedrate
    public float NomalSpeedRate;
    public float MaxSpeedRate;
    public float MinSpeedRate;
    //speed
    public float MaxSpeed;


    private float _horizontal;
    private float _Vertical;

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        if (rb==null) {
            Debug.LogError("cant find rigidbody");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void FixedUpdate() {
        _horizontal = Input.GetAxis("Horizontal");//左右
        _Vertical = Input.GetAxis("Vertical");//前后
        ChangerDirection(_horizontal, true);
        ChangerDirection(_Vertical, false);
        SpeedLimit();


        //Debug.Log("speed"+rb.velocity);
        //Debug.Log(_Vertical + "v");
       
    }
    /// <summary>
    /// 移动方向
    /// </summary>
    /// <param name="value"></param>
    /// <param name="ishorizontal">是否为横向移动 </param>
    void ChangerDirection(float value,bool ishorizontal) {
        if (ishorizontal)
        {
            if (value > 0)
            {
                rb.AddForce(Vector3.right * NomalSpeedRate);
            }
            else if (value < 0)
            {
                rb.AddForce(Vector3.left * NomalSpeedRate);
            }
            else
            {

            }
        }
        else {
            if (value > 0)
            {
                rb.AddForce(Vector3.forward * NomalSpeedRate);
            }
            else if (value < 0)
            {
                rb.AddForce(Vector3.back * NomalSpeedRate);
            }
            else
            {

            }
        }
    }
    /// <summary>
    /// 限制最大速度
    /// </summary>
    void SpeedLimit() {
        if (rb.velocity.x>=MaxSpeed) {
            Vector3 xmove= rb.velocity;
            xmove.x = MaxSpeed;
            rb.velocity = xmove;
        }
        if (rb.velocity.y >= MaxSpeed)
        {
            Vector3 xmove = rb.velocity;
            xmove.y = MaxSpeed;
            rb.velocity = xmove;
        }
        if (rb.velocity.z >= MaxSpeed)
        {
            Vector3 xmove = rb.velocity;
            xmove.z = MaxSpeed;
            rb.velocity = xmove;
        }


    }
}
