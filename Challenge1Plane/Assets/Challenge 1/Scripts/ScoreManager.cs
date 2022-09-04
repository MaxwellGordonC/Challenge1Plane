using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/*
 * Maxwell Gordon
 * Challenge 1
 */
public class ScoreManager : MonoBehaviour
{
    public static bool bGameOver;
    public static bool bWon;
    public static int score;

    public Text textbox;

    void Start()
    {
        bGameOver = false;
        bWon = false;
        score = 0;
    }

    void Update()
    {
        if (!bGameOver)
        {
            textbox.text = $"Score: {score}";
        }

        if (score >= 5)
        {
            bWon = true;
            bGameOver = true;
        }

        if (bGameOver)
        {
            if (bWon)
            {
                textbox.text = "You win!\nPress R to try again.";
            }
            else
            {
                textbox.text = "You lose.\nPress R to try again.";
            }
        }

        // MaxG: Allow resetting at any time (regardless of win condition, for convenience).
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
