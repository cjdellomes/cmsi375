using UnityEngine;
using System.Collections;

public class BulletFire : MonoBehaviour {

	public Rigidbody projectile;
	private float interval = 1;
	private float timer;

	// Use this for initialization
	void Start () {
		timer = Time.time + interval;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time >= timer){
			timer = Time.time + interval;
		}
		if(timer == Time.time + interval){
			Rigidbody instantiatedProjectile = Instantiate(projectile,transform.position,transform.rotation)as Rigidbody;
		}
	}
}
