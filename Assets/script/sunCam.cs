using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunCam : MonoBehaviour
{
    public Transform sunTarget;
    private Vector3 offset;

    private void Start()
    {
        offset = sunTarget.position -this.transform.position;
    }
    void FixedUpdate()
    {
        this.transform.position = sunTarget.position - offset;
    }
}
