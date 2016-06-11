using UnityEngine;
using System.Collections;

public class PlayerIA : MonoBehaviour {

    public GameObject Ball;
   //  private Transform CurrentTransform;
    private int speed = 5;
    Rigidbody2D rigidbody;

    // Use this for initialization
    void Start()
    {
       // CurrentTransform = this.transform;
         rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //CurrentTransform = this.transform;
        if (transform.position.x < Ball.transform.position.x)
        {
            if (transform.position.y < Ball.transform.position.y)
            {
               rigidbody.velocity = new Vector2(0, 1) * speed;
            }
            else if (transform.position.y > Ball.transform.position.y)
            {
                rigidbody.velocity = new Vector2(0, -1) * speed;
            }
            else {
               rigidbody.velocity = new Vector2(0, 0) * speed;
            }
        }
    }
}
