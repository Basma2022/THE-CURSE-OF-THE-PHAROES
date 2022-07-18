using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontOfPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    private Vector3 moveVector;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveVector.x = player.position.x;
        moveVector.y = transform.position.y;
        moveVector.z =transform.position.z;

        transform.position = moveVector;
    }
}
