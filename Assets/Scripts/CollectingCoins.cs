using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectingCoins : MonoBehaviour
{
    private int currentScore = 0;
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Update()
    {
        scoreText.text = "Score: " + currentScore;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            currentScore++;
        }
    }
}
