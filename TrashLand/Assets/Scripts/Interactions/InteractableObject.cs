using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour {

	[SerializeField]
	private Interaction[] interactions;

	// Initialization
	private void Start() {
		// Initialize each interaction instance
		foreach (Interaction i in interactions) {
			i.Init(this);
		}
	}

	// For now, pressing "P" triggers an interaction
	void Update() {
		if (Input.GetKeyDown(KeyCode.P)) {
			Interact();
		}
	}

	// This method is called whenever the player attempts to interact with this object
	// Returns true if an interaction executes, false otherwise
	public bool Interact() {
		foreach (Interaction i in interactions) {
			if (i.CanExecute()) {
				i.Execute();	// If the interaction can execute, then execute it
				return true;
			}
		}
		return false;
	}


	public void Highlight() {
	}
}
