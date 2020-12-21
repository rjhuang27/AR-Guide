using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class art : MonoBehaviour {
    public GameObject Target;
    public GameObject Canvas;
 
    //public string Text_demo;
    void Start () {}

    // Update is called once per frame
    void OnGUI (){
        if (Target.activeSelf == true) {
            //Text_demo = GUI.TextArea(new Rect(Screen.width / 8.5f, Screen.height / 9.5f, Screen.height / 1.5f, Screen.height / 5), Text_demo);
            Application.LoadLevel("scrollbar");
        }
    }
}
