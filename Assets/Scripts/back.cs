using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour
{
    public GUIStyle guistyle;
    public Texture texture;

    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public GameObject target4;
    public bool tar_1 = false;
    public bool tar_2 = false;
    public bool tar_3 = false;
    public bool tar_4 = false;



    // Use this for initialization
    void Start()
    {
       // GUI.Button(new Rect(0, 0, Screen.width, Screen.height), texture);

    }
    void OnGUI()
    {
        if (target1.activeSelf == true) tar_1 = true;
        if (target2.activeSelf == true) tar_2 = true;
        if (target3.activeSelf == true) tar_3 = true;
        if (target4.activeSelf == true) tar_4 = true;
        if ((tar_1 == true) && (tar_2 == true) && (tar_3 == true) && (tar_4 == true))
        {
            if (GUI.Button(new Rect(0, 0, Screen.width, Screen.height), "点击屏幕退出",guistyle))
            {
                Application.Quit();
            }
        }

    }
}
