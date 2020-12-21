using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuoka1 : MonoBehaviour {
    public GameObject Target;
    public GameObject Object1;
    public GameObject Object2;
    bool firstFound = false;

    // Use this for initialization
    void Start()
    {
        Object1.SetActive(false);
        Object2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Target.activeSelf == true)
        {
            Object1.SetActive(true);
            Object2.SetActive(false);
            firstFound = true;
        }
        if (Target.activeSelf == false && firstFound == true)
        {
            Object1.SetActive(false);
            Object2.SetActive(true);
        }

    }
}
