using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] dogs = { "Chihuahua", "Husky", "Yorkie", "German Shepherd" };
        for (int x = 0; x < dogs.Length; x++)
        {
            Debug.Log(dogs[x]);
        }
    }
}
