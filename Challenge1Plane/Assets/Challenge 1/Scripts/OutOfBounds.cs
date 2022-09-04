using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutOfBounds : MonoBehaviour
{
    // MaxG: Check for the player going OOB.
    void Update()
    {
        if (transform.position.y > 80 || transform.position.y < -51)
        {
            ScoreManager.bGameOver = true;
        }
    }
}
