using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{

    public float speed = 0.7f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, speed, 0f);
    }
}
