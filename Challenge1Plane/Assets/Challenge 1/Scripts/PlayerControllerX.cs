using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;


    void /*Fixed*/Update()
    {
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // MaxG: Changed from .right to .left so that W is up.
        //       Technically the opposite of how a real plane works,
        //       but it feels a bit more intuitive.
        transform.Rotate(Vector3.left * verticalInput * rotationSpeed * Time.deltaTime);
    }
}
