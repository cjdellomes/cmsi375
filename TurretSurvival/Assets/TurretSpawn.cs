using UnityEngine;
using System.Collections;

public class TurretSpawn : MonoBehaviour {

	public Object projectile;
	public float interval;
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
			Object instantiatedProjectile = Instantiate(projectile,transform.position,transform.rotation);
		}
	}
}
