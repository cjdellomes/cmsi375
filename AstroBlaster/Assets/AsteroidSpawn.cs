using UnityEngine;
using System.Collections;

public class AsteroidSpawn : MonoBehaviour {

	public Rigidbody projectile;
	public float interval;
	private float timer;

	// Use this for initialization
	void Start () {
		timer = Random.value * 10;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time >= timer){
			timer = Time.time + interval;
		}
		if(timer == Time.time + interval){
			Rigidbody instantiatedProjectile = Instantiate(projectile,transform.position,Quaternion.identity)as Rigidbody;
		}
	}
}
