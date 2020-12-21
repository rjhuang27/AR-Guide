using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollarbar : MonoBehaviour {

    //public Texture2D Texture;

	// Use this for initialization
	void Start () {
		
	}

    void OnGUI()
    {
       // GUI.DrawTexture(new Rect(0, 0, Screen.width,Screen.height), Texture, ScaleMode.StretchToFill);
        if (GUI.Button(new Rect(Screen.width - 380, Screen.height - 100, 320, 80), "返回"))
        {
            Application.LoadLevel("Tuoka");
        }
    }
}
