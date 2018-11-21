using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour {

	public int enemySpeed;
	public int xMoveDirection;

	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (xMoveDirection, 0) * enemySpeed;
	}
}
