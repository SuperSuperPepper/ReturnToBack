using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {


    public Transform spere;

    //模型偏移量
    public float Xoffic=0.32f;
    public float Yoffic=-0.42f;
    public float Zoffic=1.65f;


    private Quaternion startRotation;
    private Vector3 vec = new Vector3();
    private Vector3 rot = new Vector3();
	private BallUserControl ballControl;
    // Use this for initialization
    void Start () {
        ballControl = spere.gameObject.GetComponent<BallUserControl>();
        startRotation = this.transform.rotation;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        SetPosition();
        SetRotation1();

      
	}
    /// <summary>
    /// 设置兔子的模型和小球positon值相同 由于模型初始位置不准确所有要加上偏移量
    /// </summary>
    void SetPosition() {

        vec.x = spere.position.x + Xoffic;
        vec.y = spere.position.y + Yoffic;
        vec.z = spere.position.z + Zoffic;
        this.transform.position = vec;
    }
    /// <summary>
    /// 设置模型朝向和小球移动方向相同
    /// </summary>
    void SetRotation() {
        //得到方向
        Vector3 move = ballControl.GetMoveDirection();
       // Debug.Log(move);
        if (move == Vector3.zero) return;


            float angle = Vector3.Angle(move, transform.forward);
            rot.x = 0;
            rot.y = angle;
            rot.z = 0;
           transform.RotateAround(spere.position, Vector3.up, angle);


            //transform.Rotate(new Vector3(angle,0,0));
           // transform.Rotate(rot);


       
    }
    void SetRotation1()
    {

        Quaternion rotation = Quaternion.LookRotation(ballControl.relativePos);

        transform.rotation = rotation;

    }


}
