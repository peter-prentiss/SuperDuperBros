using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour {

	private float timeLeft = 120;
	public int playerScore = 0;
	public GameObject timeLeftUI;
	public GameObject playerScoreUI;

	void Update () {
		timeLeft -= Time.deltaTime;
		timeLeftUI.gameObject.GetComponent<Text>().text = ("Time Left: " + (int)(timeLeft));
		playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore);
		if (timeLeft < 0.1f) {
			SceneManager.LoadScene("Prototype_1");
		}
		PlayerRaycast ();
	}

	void OnTriggerEnter2D (Collider2D trig) {
		if (trig.gameObject.name == "End_Level") {
			CountScore ();
		}
		if (trig.gameObject.name == "Coin") {
			playerScore += 10;
			Destroy (trig.gameObject);
		}
	}

	void CountScore () {
		playerScore = playerScore + (int)(timeLeft * 10);
		Debug.Log(playerScore);
	}

	void PlayerRaycast () {
		RaycastHit2D hit = Physics2D.Raycast (transform.position, Vector2.down);
		if (hit.distance < 0.9f && hit.collider.tag == "enemy") {
			GetComponent<Rigidbody2D>().AddForce(Vector2.up * 1000);
		}

	}
}
