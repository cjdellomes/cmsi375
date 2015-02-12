using UnityEngine;
using System.Collections;

public class InstructionsGUI : MonoBehaviour {

	void OnGUI(){
		if (GUI.Button(new Rect(10,370,200,300), "Main Menu")){
			Application.LoadLevel("MainMenu");
		}
	}
}
