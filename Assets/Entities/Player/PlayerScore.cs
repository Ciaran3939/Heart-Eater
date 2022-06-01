using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    private float playerScore = 0f;

    [SerializeField] private Text scoreText;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NPC"))
        {
            playerScore = playerScore - 1f;
            scoreText.text = "Player Health: " + playerScore;
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            playerScore = playerScore + 2f;
            scoreText.text = "Player Health: " + playerScore;
        }


        if (playerScore >= 6)
        {
            Application.LoadLevel("Win");
        }
    }
}
