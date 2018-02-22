using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interaction : MonoBehaviour {

	[SerializeField]
	private InteractionCondition condition;
	private InteractableObject iObject;

	private void Update() {
	}

	public abstract void Execute();

	// Initialize this instance
	public virtual void Init(InteractableObject interactableObject) {
		this.iObject = interactableObject;
	}

	// Returns true if this interaction can execute (its condition is met), false otherwise
	public bool CanExecute() {
		return condition.Check();
	}
}
