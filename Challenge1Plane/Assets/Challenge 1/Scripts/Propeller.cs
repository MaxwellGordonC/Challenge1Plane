using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    public float RotationRate;

    void Update()
    {
        // MaxG: Add to rotation every tick.
        transform.Rotate(Vector3.forward * RotationRate * Time.deltaTime);
    }
}
