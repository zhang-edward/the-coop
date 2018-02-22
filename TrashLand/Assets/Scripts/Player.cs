using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private const float SPEED_X = 0.1f;	// How fast the player moves along the x-axis, in units per second
	private const float SPEED_Y = 0.05f;    // How fast the player moves along the y-axis, in units per second
	private const float HORIZON = 0.6f; // What portion of the screen can the player not go to
	private const float LEFT = 0.05f; // from 0, leftmost position player can move
	private const float RIGHT = 0.95f; // from 1, rightmost position

	public DepthHandler depth;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		MovePlayer ();
	}

	void MovePlayer(){
		Vector2 s = Camera.main.WorldToViewportPoint (transform.position);
		float vy = 0f; float vx = 0f; float vdir = Input.GetAxisRaw ("Vertical"); float hdir = Input.GetAxisRaw ("Horizontal");
		Debug.Log (vx);

		if (!((s.y > HORIZON && vdir == 1) || (s.y < 0.1 && vdir == -1))) {
			// only update vy if its in between the horizon and floor, and that it moves in the right dir
			vy = vdir * SPEED_Y * ((transform.position.y - depth.Horizon) * -0.2f);
		}

		if (!((s.x > RIGHT && hdir == 1) || (s.x < LEFT && hdir == -1))) {
			// only update vy if its in between the horizon and floor, and that it moves in the right dir
			vx = hdir * SPEED_X * ((transform.position.y - depth.Horizon) * -0.2f);;
		}

		transform.Translate(vx, vy, 0);
	}

}