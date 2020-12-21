using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text_tuoka : MonoBehaviour
{
    public GameObject Dragon;
    public GameObject Target;
    public GameObject Target1;
    public GameObject Target2;
    public GameObject Target3;
    public GameObject Zhen;
    bool firstFound = false;


    // Use this for initialization

    // Update is called once per frame
    void Update()
    {
        if (Target.activeSelf == true)
        {
            Zhen.SetActive(true);
            Dragon.SetActive(true);
        }
        if (Target.activeSelf == false)
        {
            firstFound = true;
        }
        if ((firstFound == true) && ((Target1.activeSelf == true) || (Target2.activeSelf == true) || (Target3.activeSelf == true)))
        {
            Zhen.SetActive(false);
            firstFound = false;
        }
    }
}