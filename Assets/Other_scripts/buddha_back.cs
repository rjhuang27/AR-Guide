using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buddha_back : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width - 380, Screen.height - 100, 320, 80), "返回"))
        {
            Application.LoadLevel("buddha");
        }
    }
}
