using UnityEngine;
using System.Collections;

public class KeepScore : MonoBehaviour {

	public static int pScore = 0;
	public static int oScore = 0;

	// Use this for initialization
	void Start () {

		DontDestroyOnLoad(transform.gameObject);

	}
	
	// Update is called once per frame
	void Update () {

		if(pScore == 9){
			victory("player");
		}

		else if(oScore == 9){
			victory("opponent");
		}

	}

	public void victory(string winner){

		if(winner == "player"){
			Debug.Log("Player wins");
			Application.LoadLevel("PlayerVictory");
		}

		else if(winner == "opponent"){
			Debug.Log("Opponent wins");
			Application.LoadLevel("OpponentVictory");
		}

	}

}
