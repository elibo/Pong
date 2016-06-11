using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour {
    [SerializeField]
    private KeyCode up = KeyCode.UpArrow;
    [SerializeField]
    private KeyCode down = KeyCode.DownArrow;
    [SerializeField]
    private float speed=10;

    Rigidbody2D rigidbody;


    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
	}


    public void FixedUpdate()
    {
        Vector2 velocity = Vector2.zero;

        if (Input.GetKey(up))
        {
            velocity.y = speed;
        }
        else if (Input.GetKey(down))
        {
            velocity.y = -speed;
        }

        rigidbody.velocity = velocity;
    }
}
