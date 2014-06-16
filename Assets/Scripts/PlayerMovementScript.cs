using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {
	public float speedF;
	public float speedB;
	
	void Start () {
		
	
	}
	
	void Update () {
		
		
		if(Input.GetKey(KeyCode.W))
		{
			rigidbody.AddRelativeForce(new Vector3(0,0,speedF));
		}
		if(Input.GetKey(KeyCode.S))
		{
			rigidbody.AddRelativeForce(new Vector3(0,0,speedB));
		}
		if(Input.GetKey(KeyCode.A))
		{
			transform.Rotate(new Vector3(0,-10,0));	
		}
		if(Input.GetKey(KeyCode.D))
		{
			transform.Rotate(new Vector3(0,10,0));	
		}
		
	
	}
}
