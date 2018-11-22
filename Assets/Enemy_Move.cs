﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour {

	public int enemySpeed;
	public int xMoveDirection;

	// Update is called once per frame
	void Update () {
		RaycastHit2D hit = Physics2D.Raycast (transform.position, new Vector2 (xMoveDirection, 0));
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (xMoveDirection, 0) * enemySpeed;
		if (hit.distance <0.7f) {
			Flip ();
		}
	}

	void Flip () {
		if (xMoveDirection < 0) {
			xMoveDirection = -1;
		} else {
			xMoveDirection = 1;
		}
	};
}