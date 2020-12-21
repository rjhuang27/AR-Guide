using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuoka : MonoBehaviour {
    public GameObject Target;
    public GameObject Target1;
    public GameObject Target2;
    public GameObject Target3;
    public GameObject Dragon;
    public GameObject Zhen;
    public GameObject Zhen2;
    bool firstFound = false;


    // Use this for initialization
    void Start()
    {
        Zhen.SetActive(false);
        Zhen2.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Target.activeSelf == true)
        {
            Zhen.SetActive(true);
            Zhen2.SetActive(false);
            firstFound = true;
            Dragon.SetActive(true);
        }
        if (Target.activeSelf == false && firstFound == true)
        {
            Zhen.SetActive(false);
            Zhen2.SetActive(true);
            Dragon.SetActive(true);
        }
        if ((Zhen2.activeSelf == true) && ((Target1.activeSelf == true)|| (Target2.activeSelf == true) || (Target3.activeSelf == true)))
        {
            Zhen2.SetActive(false);
            firstFound = false;
            Dragon.SetActive(true);
        }
    }
}
