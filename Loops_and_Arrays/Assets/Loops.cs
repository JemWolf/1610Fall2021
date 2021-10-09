using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called before the first frame update
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
