using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public float speed = 0.1f;

	private Rigidbody2D rb2d;
	// Use this for initialization
	void Start () 
	{
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		//Store the current horizontal input in the float moveHorizontal.
		float moveHorizontal = Input.GetAxis ("Horizontal");

		//Store the current vertical input in the float moveVertical.
		float moveVertical = Input.GetAxis ("Vertical");

		//Use the two store floats to create a new Vector2 variable movement.
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		//Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
		rb2d.AddForce (movement * speed);
	}
}
