using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    void Start()
    {
        for (int x = 0; x < 10; x++)
       
        {
            Debug.Log(x);
            x++;
        }
      
    }
}
