using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixRotator : MonoBehaviour
{
    public float RotationSpeed;

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            float Mousex = Input.GetAxisRaw("Mouse X");
            transform.Rotate(0, -Mousex * RotationSpeed * Time.deltaTime, 0);
        }
    }
}
    