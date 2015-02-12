using UnityEngine;
using System.Collections;

public class RandomDirectionShot : MonoBehaviour {

	public int ballSpeed;

	// Use this for initialization
	void Start () {

		int randomDirection = Random.Range(1,2);
		int verticalForce = Random.Range(-ballSpeed,ballSpeed);

		while(verticalForce >-100 && verticalForce < 100){
			verticalForce = Random.Range(-ballSpeed,ballSpeed);
		}

		if(randomDirection == 1){
			rigidbody.AddForce(Vector3.left * ballSpeed);
			rigidbody.AddForce(0,0,verticalForce);
		}

		if(randomDirection == 2){
			rigidbody.AddForce(Vector3.right * ballSpeed);
			rigidbody.AddForce(0,0,verticalForce);
		}
	
	}
	
}
