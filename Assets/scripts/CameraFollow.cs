using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;

    public Vector3 offset;

    Vector3 test;

    private void Start()
    {
        
        test = new Vector3(1, 0, 0);
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(Target.position.x, 0, 0) + offset;

    }
}