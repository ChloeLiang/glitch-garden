using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
	public float health = 100f;

	public void DealDamange(float damage) {
		health -= damage;
		if (health < 0) {
			// Optionally trigger animation
			DestroyObject();
		}
	}

	// Call death animation in Animator Event
	public void DestroyObject() {
		Destroy(gameObject);
	}
}
