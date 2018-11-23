using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour {

	// Use this for initialization
	void Update () {
		if (gameObject.transform.position.y < -7) {
			Destroy (gameObject);
		}
	}
}
