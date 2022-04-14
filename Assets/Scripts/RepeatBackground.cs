using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidht;

    void Start()
    {
        startPos = transform.position;
        repeatWidht = GetComponent<BoxCollider>().size.x / 2;
    }

    void Update()
    {
        if(transform.position.x < startPos.x - repeatWidht)
        {
            transform.position = startPos;
        }
    }
}
