using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyAR;
public class VideoCon : MonoBehaviour
{

    private bool isClick = false;

    void OnMouseDown()
    {
        if (!isClick)
        {

            this.GetComponent<VideoPlayerBehaviour>().Pause();
            isClick = true;
        }
        else
        {
            this.GetComponent<VideoPlayerBehaviour>().Play();
            isClick = false;
        }

    }
}