using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toCreditScene : MonoBehaviour
{
    void Start()
    {
        Invoke("ToCredit", 3f);
    }

    void ToCredit()
    {
        SceneManager.LoadScene("CreditScreen");
    }

   
}
