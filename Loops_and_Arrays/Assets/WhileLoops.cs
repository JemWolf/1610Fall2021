using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    void Start()
    {
        int x = 0;
        do 
        {
            Debug.Log(x);
            x++;
        }
        while (x < 10)
    }
    
}
