using UnityEngine;
using System.Collections;

public class HorizontalTurret : MonoBehaviour {

	public float speed;
	public bool goingLeft;
	public bool goingRight;

	void Start(){
		goingLeft = true;
		goingRight = false;
	}
	
	// Update is called once per frame
	void Update () {

		if(transform.position.x > 5.9 && transform.position.x > -5.9){
			goingLeft = true;
			goingRight = false;
		}

		else if(transform.position.x < -5.9 && transform.position.x < 5.9){
			goingRight = true;
			goingLeft = false;
		}

		if(goingLeft){
			transform.Translate(Vector3.left * speed);
		}

		else if(goingRight){
			transform.Translate(Vector3.right * speed);
		}

		DontDestroyOnLoad(this.gameObject);

	}
	
}
