
using UnityEngine;

public class Rotaion : MonoBehaviour
{
    private float y;
   // private float z;
  //  private bool rotatey;
    private float rotationSpeed;

    void Start()
    {
        y = 0.0f;

        rotationSpeed = 75.0f;
    }

    void Update()
    {
        
         
                y += Time.deltaTime * rotationSpeed;

                if (y > 360.0f)
                {
                    y = 0.0f;
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

            transform.localRotation = Quaternion.Euler(0, y, 0);
        }
    
}
