using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCondition : InteractionCondition {

	// For an actual condition, we would assign an actual check
	public override bool Check() {
		return true;	// Always true
	}
}
