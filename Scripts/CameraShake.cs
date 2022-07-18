using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{

   public float nextShakeTime = 0 ;
    public GameObject cameraHolder;
   public IEnumerator Shake(float duration , float magnitude)
    {
        Vector3 originalPosition = transform.localPosition;
        float elapsed = 0.0f;

        while(elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, originalPosition.z);

            elapsed += Time.deltaTime;

            yield return null;
        }
        transform.localPosition = originalPosition;
    }

    void Update()
    {

        if (cameraHolder.transform.position.z <= 100.0f)
            StartCoroutine(Shake(.5f, .3f));
        
     
        if(cameraHolder.transform.position.z >= 200.0f && cameraHolder.transform.position.z < 300.0f)
            StartCoroutine(Shake(.5f, .3f));

        if (cameraHolder.transform.position.z  >= 400.0f && cameraHolder.transform.position.z  < 460.0f)
            StartCoroutine(Shake(.5f, .3f));
    }

}
