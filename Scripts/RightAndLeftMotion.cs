using UnityEngine;
using System.Collections;

public class RightAndLeftMotion : MonoBehaviour
{
    public float delta ;  // Amount to move left and right from the start point
    public float speed ;
    private Vector3 startPos;
    public bool isLeft;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 v = startPos;

        if(isLeft)
        v.x -= delta * Mathf.Sin(Time.time * speed);
        else
            v.x += delta * Mathf.Sin(Time.time * speed);


        transform.position = v;

    }
}