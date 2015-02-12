using UnityEngine;
using System.Collections;

public class ScoreGUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(transform.gameObject);
	}
	
	// Update is called once per frame
	void OnGUI () {
		GUI.Label(new Rect(10,10,100,20), KeepScore.pScore + "-" + KeepScore.oScore);
	}
}
