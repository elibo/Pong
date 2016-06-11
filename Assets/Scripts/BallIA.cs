using UnityEngine;
using System.Collections;


public class BallIA : MonoBehaviour
{
    Rigidbody2D rigibody;
   

   
   GameManagerIA gamemanager;

    [SerializeField]
    private float force;
    [SerializeField]
    private AudioSource clip;
    [SerializeField]
    private AudioSource clip2;

    public bool endgame;

    // Use this for initialization
    void Start()
    {
       
        gamemanager = FindObjectOfType<GameManagerIA>();
        rigibody = GetComponent<Rigidbody2D>();
        endgame = false;
        ResetBall();

    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Right"))
        { 
            gamemanager.playerScores(1);
           


        }
        else if (collision.gameObject.CompareTag("Left"))
        {
           gamemanager.playerScores(2);
          

        }
        if (gamemanager.player1Score < gamemanager.pointstowin && gamemanager.player2Score < gamemanager.pointstowin) 
        {
            ResetBall();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Red"))
            clip.Play();
        else if (collision.gameObject.CompareTag("Blue"))
            clip.Play();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Right"))
            clip2.Play();
        else if (collision.gameObject.CompareTag("Left"))
            clip2.Play();
    }

    private void ResetBall()
    {
        transform.position = Vector2.zero;
        rigibody.velocity = Vector2.zero;

        float x = Random.Range(1f, 3f);
        x *= Random.Range(0, 2) * 2 - 1;
        float y = Random.Range(-3f, 3f);

        Vector2 forceVector = new Vector2(x, y).normalized * force;

        rigibody.AddForce(forceVector);

    }
}
