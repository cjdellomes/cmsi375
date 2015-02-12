using UnityEngine;
using System.Collections;

public class VerticalTurret : MonoBehaviour {

	public float speed;
	public bool goingDown;
	public bool goingUp;

	void Start(){
		goingDown = true;
		goingUp = false;

	}
	
	// Update is called once per frame
	void Update () {

		if(transform.position.z > 3.2 && transform.position.z > -3.2){
			goingDown = true;
			goingUp = false;
		}

		else if(transform.position.z < -3.2 && transform.position.z < 3.2){
			goingUp = true;
			goingDown = false;
		}

		if(goingDown){
			transform.Translate(Vector3.back * speed);
		}

		else if(goingUp){
			transform.Translate(Vector3.forward * speed);
		}

		DontDestroyOnLoad(this.gameObject);


	}
	
}
