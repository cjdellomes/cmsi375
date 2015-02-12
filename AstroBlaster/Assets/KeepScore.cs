using UnityEngine;
using System.Collections;

public class KeepScore : MonoBehaviour {

	public int score = 0;
	public GUIText scoreText;

	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScore();
	}
	
	// Update is called once per frame
	public void AddScore () {
		score++;
		UpdateScore();
	}

	void UpdateScore(){
		scoreText.text = "Score: " + score;
	}
}
