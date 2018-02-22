using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class DepthHandler : MonoBehaviour {

	// For every 1 unit in the y direction, objects with depth will scale down by this percent
	private const float DEPTH_TO_SCALE_PERCENT = 0.2f;
	[SerializeField]
	private GameObject[] objects;

	// The y-coordinate at which this transform will shrink to scale = 0
	public float Horizon
	{
		get
		{
			return 1 / DEPTH_TO_SCALE_PERCENT;
		}
	}

	// The scale values that this transform should start with
	public Vector3 originalScale;

	void Update() {
		// As y gets bigger, sprite becomes smaller
		// At y = 0, the transform has scale = 1
		float scaleFactor = 1 - (transform.position.y * DEPTH_TO_SCALE_PERCENT);
		transform.localScale = originalScale * scaleFactor;
		// Debug
		if (transform.position.y >= Horizon) {
			Debug.Log("Horizon reached!");
		}
	}
}
