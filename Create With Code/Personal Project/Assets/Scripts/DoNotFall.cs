using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotFall : MonoBehaviour
{
    public float yRange = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -yRange)
        {
            transform.position = new Vector3(transform.position.y, -yRange, transform.position.z);
        }
    }
}
