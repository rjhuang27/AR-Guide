using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_model : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (1 == Input.touchCount)
        {

            Touch touch = Input.GetTouch(0);

            Vector3 deltaPos = touch.deltaPosition;

            transform.Rotate(Vector3.down * deltaPos.x, Space.Self);//绕Y轴进行旋转
            //transform.Rotate(Vector3.right * deltaPos.y, Space.World);//绕X轴进行旋转
            //transform.Rotate(Vector3.forward * deltaPos.z, Space.World);//绕z轴
        }

    }
}
