using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private const float SPEED_X = 0.1f;	// How fast the player moves along the x-axis, in units per second
	private const float SPEED_Y = 0.05f;    // How fast the player moves along the y-axis, in units per second

	public DepthHandler depth;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float vx = Input.GetAxisRaw("Horizontal") * SPEED_X * ((transform.position.y - depth.Horizon) * -0.2f);
		float vy = Input.GetAxisRaw("Vertical") * SPEED_Y * ((transform.position.y - depth.Horizon) * -0.2f);

		transform.Translate(vx, vy, 0);
	}
}
