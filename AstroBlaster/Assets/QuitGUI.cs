using UnityEngine;
using System.Collections;

public class QuitGUI : MonoBehaviour {

	void OnGUI(){
		if (GUI.Button(new Rect(10, 70, 200, 300), "Quit")){
			Application.Quit();
		}
		if (GUI.Button(new Rect(210,70,200,300), "Main Menu")){
			Application.LoadLevel("MainMenu");
		}
	}
}
