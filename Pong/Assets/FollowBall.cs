using UnityEngine;
using System.Collections;

public class FollowBall : MonoBehaviour {

	public Transform ball;
	public float speed;


	// Update is called once per frame
	void Update () {

		speed = Time.deltaTime * 7;

		if (ball.position.z >= transform.position.z+1){
			transform.Translate(Vector3.forward * speed);
		}

		else if (ball.position.z <= transform.position.z-1){
			transform.Translate(Vector3.back * speed);
		}

	}

}
