using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UIrotate : MonoBehaviour
{

    public Image[] tips;
    public float Vspeed=0.2f;
    public float Hspeed = 0.2f;
    public float Plane = 0.2f;
    void Update()
    {
        

        for (int i = 0; i < tips.Length; i++)
        {
           tips[i].transform.Rotate(Vspeed, Hspeed, Plane);
        }
    }
}
