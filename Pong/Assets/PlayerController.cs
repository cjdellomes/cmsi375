using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public int speed;
	public bool upColliding = false;
	public bool downColliding = false;
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey("up") && upColliding == false){
			transform.Translate(0,0,(Time.deltaTime * speed));
			downColliding = false;
		}

		if(Input.GetKey("up") && upColliding == true){
			downColliding = false;
		}

		if(Input.GetKey("down") && downColliding == false){
			transform.Translate(0,0,(-Time.deltaTime * speed));
			upColliding = false;
		}

		if(Input.GetKey("down") && downColliding == true){
			upColliding = false;
		}
	
	}

	void OnTriggerEnter(){

		upColliding = true;
		downColliding = true;

	}

}
