using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buddha : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width - 380, 100, 320, 80), "模型旋转"))
        {
            //加载关卡
            Application.LoadLevel("Rotation");
        }
        if (GUI.Button(new Rect(Screen.width - 380, 300, 320, 80), "模型放大缩小"))
        {
            //加载关卡
            Application.LoadLevel("Scale");
        }
        if (GUI.Button(new Rect(Screen.width - 380, Screen.height - 100, 320, 80), "返回主界面"))
        {
            Application.LoadLevel("main");
        }
    }
}
