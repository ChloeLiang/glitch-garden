﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {

	private float currentSpeed;
	private GameObject currentTarget;
	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
		if (!currentTarget) {
			animator.SetBool("isAttacking", false);
		}
	}

	void OnTriggerEnter2D () {
		Debug.Log(name + " trigger enter");
	}

	public void SetSpeed (float speed) {
		currentSpeed = speed;
	}

	// Called from the animator at the time of actual blow
	public void StrikeCurrentTarget (float damage) {
		if (currentTarget) {
			Health health = currentTarget.GetComponent<Health>();
			if (health) {
				health.DealDamange(damage);
			}
		}
	}

	public void Attack (GameObject obj) {
		currentTarget = obj;
	}
}
