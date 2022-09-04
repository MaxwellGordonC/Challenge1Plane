using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;

    // MaxG: Set in the editor.
    public Vector3 offset;

    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
