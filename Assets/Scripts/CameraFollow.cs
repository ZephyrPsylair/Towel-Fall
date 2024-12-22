using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public Vector3 Offset;
    public float SmoothSpeed;

    void Start()
    {
        Offset = transform.position - Target.position;      
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 NewPos = Vector3.Lerp(transform.position, Target.position + Offset, SmoothSpeed);
        transform.position = NewPos;
    }
}
