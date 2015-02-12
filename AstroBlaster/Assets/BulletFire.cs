using UnityEngine;
using System.Collections;

public class BulletFire : MonoBehaviour {

	public Rigidbody projectile;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space")){
			Rigidbody instantiatedProjectile = Instantiate(projectile,transform.position,Quaternion.identity)as Rigidbody;
		}
	}
}
