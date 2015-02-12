using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public bool isReset = false;
	public bool oScored = false;
	public bool pScored = false;
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x >= 10){
			pScored = true;
			isReset = true;
		}
		if(transform.position.x <= -10){
			oScored = true;
			isReset = true;
		}
	}

	void LateUpdate(){
		if(isReset){
			Application.LoadLevel("Pong");
		}
		if(pScored){
			KeepScore.pScore++;
		}
		else if(oScored){
			KeepScore.oScore++;
		}
	}
}
