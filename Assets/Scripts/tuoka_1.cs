using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuoka_1 : MonoBehaviour
{
    public GameObject Gragon;
    public GameObject Target;
    public GameObject Target1;
    public GameObject Target2;
    public GameObject Target3;
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
        if (Target2.activeSelf == true)
        {
            Gragon.SetActive(true);
            Zhen.SetActive(true);
            Zhen2.SetActive(false);
            firstFound = true;
        }
        if (Target2.activeSelf == false && firstFound == true)
        {
            Zhen.SetActive(false);
            Zhen2.SetActive(true);
            Gragon.SetActive(true);
        }
        if ((Zhen2.activeSelf == true) && ((Target.activeSelf == true) || (Target1.activeSelf == true) || (Target3.activeSelf == true)))
        {
            Zhen2.SetActive(false);
            firstFound = false;
            Gragon.SetActive(true);
        }
    }
}
