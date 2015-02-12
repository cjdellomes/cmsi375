using UnityEngine;
using System.Collections;

public class LevelReset : MonoBehaviour {

	public bool isReset = false;

	void onTriggerEnter(){
		isReset = true;
	}

	void onCollisionEnter(Collision collision){
		isReset = true;
	}

	// Update is called once per frame
	void Update () {
		if(isReset){
			Application.LoadLevel("Pong");
		}
	}
}
