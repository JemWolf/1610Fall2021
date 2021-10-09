using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    void Start()
    {
        int x = 0;
        while (x < 10)
        {
            Debug.Log(x);
            x++;
        }
    }
}
