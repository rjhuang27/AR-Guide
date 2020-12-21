using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour {
   // public Texture2D texture;
    //public GUIContent guiontent;
    public GUIStyle guistyle;

    // Use this for initialization
    void Start () {
		
	}
    void OnGUI()
    {
        //GUI.DrawTexture(new Rect(0, 0, Screen.width,Screen.height), texture, ScaleMode.StretchToFill);

        if (GUI.Button(new Rect(0, 0, Screen.width, Screen.height), "点击进入AR世界",guistyle))
        {
            //加载关卡
            Application.LoadLevel("Tuoka");
        }
    }
}
