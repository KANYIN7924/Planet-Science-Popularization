using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public Transform planet;
    public float speed = 10f;

    private void Update()
    {
        this.transform.RotateAround(planet.position, planet.forward, speed * Time.deltaTime);
    }

}
