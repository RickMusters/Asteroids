using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		Destroy(gameObject,1.5f);
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.velocity = Vector3.zero;
		
		rigidbody.AddRelativeForce(new Vector3(0,0,speed));
	}
	
}
