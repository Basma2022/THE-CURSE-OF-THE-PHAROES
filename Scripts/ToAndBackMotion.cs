using UnityEngine;
using System.Collections;

public class ToAndBackMotion : MonoBehaviour
{
    public float delta;  // Amount to move left and right from the start point
    public float speed = 2.0f;
    private Vector3 startPos;
    public bool isLeft;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 v = startPos;

        if (isLeft)
            v.z -= delta * Mathf.Sin(Time.time * speed);
        else
            v.z += delta * Mathf.Sin(Time.time * speed);


        transform.position = v;
    }
}