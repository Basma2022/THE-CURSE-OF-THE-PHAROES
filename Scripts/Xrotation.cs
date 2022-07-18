using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xrotation : MonoBehaviour
{
    private float z;
    // private float z;
    //  private bool rotatey;
    private float rotationSpeed;

    void Start()
    {
        z = 0.0f;

        rotationSpeed = 75.0f;
    }

    void Update()
    {


        z += Time.deltaTime * rotationSpeed;

        if (z > 360.0f)
        {
            z = 0.0f;
            //     rotatey = false;
        }

        //else
        //{
        //    z += Time.deltaTime * rotationSpeed;

        //    if (z > 360.0f)
        //    {
        //        z = 0.0f;
        //        rotatey = true;
        //    }
        //}

        transform.localRotation = Quaternion.Euler(270, 0, z);
    }
}
