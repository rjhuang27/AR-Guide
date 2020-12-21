using UnityEngine;
using System.Collections;

public class text: MonoBehaviour
{

    public float speed;
    void Update()
    {
        if (speed != 0)
        {
            float y = transform.localPosition.y + speed * Time.deltaTime;
            if (y > 1800) { y = 0; }
            transform.localPosition = new Vector3(100,y, 0);
        }
    }

}


