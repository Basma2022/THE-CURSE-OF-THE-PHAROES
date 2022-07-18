using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDownMotion : MonoBehaviour
{
    // Start is called before the first frame update

    public float delta;  // Amount to move left and right from the start point
    public float speed;
    private Vector3 startPos;
    public bool isDown;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 v = startPos;

        if (isDown)
            v.y -= delta * Mathf.Sin(Time.time * speed);
        else
            v.y += delta * Mathf.Sin(Time.time * speed);


        transform.position = v;

    }
}

