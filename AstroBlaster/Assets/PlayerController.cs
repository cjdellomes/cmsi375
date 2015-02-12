using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Rigidbody projectile;
	private readonly double LEFTMAX = -8.8;
	private readonly double RIGHTMAX = 8.8;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("left") && transform.position.x > LEFTMAX){
			transform.Translate(-Time.deltaTime * speed, 0, 0);
		}
		if(Input.GetKey("right") && transform.position.x < RIGHTMAX){
			transform.Translate(Time.deltaTime * speed, 0, 0);
		}
	}

	void OnTriggerEnter(){
		Application.LoadLevel("GameOver");
	}
}
