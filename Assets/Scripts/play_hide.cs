using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play_hide : MonoBehaviour
{
    public GameObject Target;
    public GameObject Canvas;
    public bool recognize=false;
    public int false_count = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Target.activeSelf == true)
        {
            Canvas.SetActive(true);
            recognize = true;
        }

        if ((Target.activeSelf == false) && (recognize == true))
        {
            false_count = false_count + 1;
        }

        if (false_count >500)
        {
            Canvas.SetActive(false);
            false_count = 0;
            recognize = false;

        }
    }

        
    }


