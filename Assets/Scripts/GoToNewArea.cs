using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToNewArea : MonoBehaviour {

	public GameObject sp1, sp2;

	void Start () {
		sp1 = this.gameObject;
	}
	
	// Update is called once per frame
	void OnTriggerStay2D (Collider2D trig) {
		if (Input.GetButtonDown("Jump")) {
			trig.gameObject.transform.position = sp2.transform.position;
		}
	}
}