using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopPlane : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 StartPosition;

    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
        if (transform.position.z < 12.3f)
        {
            transform.position = StartPosition;
        }
    }
}
