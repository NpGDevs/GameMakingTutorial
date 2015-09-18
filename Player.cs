using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    Rigidbody2D rigidbody;
    public float speed;
    public float maxspeed;


	// Use this for initialization
	void Start () {

        rigidbody = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
	                                //x                         Y
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (input.x != 0)
        {
            rigidbody.AddForce(new Vector2(input.x * speed, 0));
        }
        if (Mathf.Abs(rigidbody.velocity.x) > maxspeed)
        {
            rigidbody.velocity = new Vector2(maxspeed * input.x, rigidbody.velocity.y);
        }
        if (input.y != 0)
        {
            rigidbody.AddForce(new Vector2(0, input.y * speed));
        }



	}
}
