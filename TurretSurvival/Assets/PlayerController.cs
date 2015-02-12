using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public int speed;
	public bool reset = false;
	public bool upColliding = false;
	public bool downColliding = false;
	public bool leftColliding = false;
	public bool rightColliding = false;
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey("up") && upColliding == false){
			transform.Translate(0,0,(Time.deltaTime * speed));
			downColliding = false;
			if(leftColliding == true){
				leftColliding = true;
			}
			else{
				leftColliding = false;
			}
			if(rightColliding == true){
				rightColliding = true;
			}
			else{
				rightColliding = false;
			}
		}

		if(Input.GetKey("up") && upColliding == true){
			downColliding = false;
			rightColliding = false;
			leftColliding = false;
		}

		if(Input.GetKey("down") && downColliding == false){
			transform.Translate(0,0,(-Time.deltaTime * speed));
			upColliding = false;
			if(leftColliding == true){
				leftColliding = true;
			}
			else{
				leftColliding = false;
			}
			if(rightColliding == true){
				rightColliding = true;
			}
			else{
				rightColliding = false;
			}
		}

		if(Input.GetKey("down") && downColliding == true){
			upColliding = false;
			leftColliding = false;
			rightColliding = false;
		}

		if(Input.GetKey("left") && leftColliding == false){
			transform.Translate((-Time.deltaTime * speed),0,0);
			rightColliding = false;
			if(upColliding == true){
				upColliding = true;
			}
			else{
				upColliding = false;
			}
			if(downColliding == true){
				downColliding = true;
			}
			else{
				downColliding = false;
			}
		}

		if(Input.GetKey("left") && leftColliding == true){
			rightColliding = false;
			upColliding = false;
			downColliding = false;
		}

		if(Input.GetKey("right") && rightColliding == false){
			transform.Translate((Time.deltaTime * speed),0,0);
			leftColliding = false;
			if(upColliding == true){
				upColliding = true;
			}
			else{
				upColliding = false;
			}
			if(downColliding == true){
				downColliding = true;
			}
			else{
				downColliding = false;
			}
		}

		if(Input.GetKey("right") && rightColliding == true){
			leftColliding = false;
			upColliding = false;
			downColliding = false;
		}

		if(transform.position.z < -3.3){
			downColliding = true;
			upColliding = false;
		}
		else if(transform.position.z > 3.3){
			upColliding = true;
			downColliding = false;
		}
		if(transform.position.x < -5.8){
			leftColliding = true;
			rightColliding = false;
		}
		else if(transform.position.x > 5.8){
			rightColliding = true;
			leftColliding = false;
		}

		if(reset == true){
			Application.LoadLevel(Application.loadedLevel);
		}

	}

	void OnTriggerEnter(Collider col){

		upColliding = true;
		downColliding = true;
		leftColliding = true;
		rightColliding = true;
		if(col.gameObject.tag != "Respawn"){
			reset = true;
		}

	}

}
