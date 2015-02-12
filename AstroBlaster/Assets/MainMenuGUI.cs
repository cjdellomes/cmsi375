using UnityEngine;
using System.Collections;

public class MainMenuGUI : MonoBehaviour {

	void OnGUI(){
		if (GUI.Button(new Rect(10, 70, 200, 300), "Play")){
			Application.LoadLevel("GameSpace");
		}
		if (GUI.Button(new Rect(210,70,200,300), "Instructions")){
			Application.LoadLevel("Instructions");
		}
		if (GUI.Button(new Rect(410,70,200,300), "Quit")){
			Application.Quit();
		}
	}
}
