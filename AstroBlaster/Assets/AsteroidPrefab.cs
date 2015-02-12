using UnityEngine;
using System.Collections;

public class AsteroidPrefab : MonoBehaviour {

	public float speed;
	private KeepScore keepScore;

	// Use this for initialization
	void Start(){
		GameObject gameControllerObject = GameObject.FindWithTag("GameController");
		if (gameControllerObject != null)
        {
            keepScore = gameControllerObject.GetComponent <KeepScore>();
        }
	}
	
	// Update is called once per frame
	void Update(){
		transform.Translate(Vector3.down * speed);
		if(transform.position.y < -6){
			Application.LoadLevel("GameOver");
		}
	}

	void OnTriggerEnter(){
		keepScore.AddScore();
		Destroy(this.gameObject);
	}
}
