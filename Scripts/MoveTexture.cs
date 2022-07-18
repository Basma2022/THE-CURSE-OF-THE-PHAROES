using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTexture : MonoBehaviour
{
    public float scrollspeed = 0.3f;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();    
    }

    // Update is called once per frame
    void Update()
    {
        float moveThis = Time.time * scrollspeed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(0, moveThis));
    }
}
