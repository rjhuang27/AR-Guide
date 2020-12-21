using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {
    private Touch oldTouch;
    void Update () {
        if (1 == Input.touchCount)
        {

            Touch touch = Input.GetTouch(0);

            Vector2 deltaPos = touch.deltaPosition;

           transform.Rotate(Vector3.down * deltaPos.x, Space.World);

            //transform.Rotate(Vector3.right * deltaPos.y, Space.World);
        }
    }
}


