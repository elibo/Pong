using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameManagerIA : MonoBehaviour
{


    public int player1Score;
    public int player2Score;
    [SerializeField]
    public int pointstowin = 10;

    public Text player1ScoreText;
    public Text player2ScoreText;

    [SerializeField]
    private GameObject Winner1;

    [SerializeField]
    private GameObject Winner2;

    Ball ball;

    // Use this for initialization
    void Start()
    {
        player1Score = 0;
        player2Score = 0;
        ball = FindObjectOfType<Ball>();
    }

    void Restart()
    {
        Application.LoadLevel("gameIA");
    }

    public void playerScores(int playernum)
    {
        if (playernum == 1)
        {
            player1Score++;
            player1ScoreText.text = "Player 1: " + player1Score;
        }
        else if (playernum == 2)
        {
            player2Score++;
            player2ScoreText.text = "Player 2: " + player2Score;
        }

        if (player1Score == pointstowin)
        {
            Winner1.SetActive(true);
            Image image = Winner1.GetComponent<Image>();
            image.CrossFadeAlpha(0, 0, false);
            image.CrossFadeAlpha(1, 1.5f, false);
            ball.endgame = true;

        }
        else if (player2Score == pointstowin)
        {
            Winner2.SetActive(true);
            Image image = Winner2.GetComponent<Image>();
            image.CrossFadeAlpha(0, 0, false);
            image.CrossFadeAlpha(1, 1.5f, false);
            ball.endgame = true;
        }
    }

  


}
