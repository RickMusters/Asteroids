using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

	
	void Update () {
		if(gameObject.rigidbody.position.x > 32)
		{
			Vector3 temp = new Vector3(-30,1,0);
			gameObject.rigidbody.transform.position = temp;
		}
		if(gameObject.rigidbody.position.x  < -32)
		{
			Vector3 temp = new Vector3(30,1,0);
			gameObject.rigidbody.transform.position = temp;
		}
		if(gameObject.rigidbody.position.z > 12)
		{
			Vector3 temp = new Vector3(0,1,-12);
			gameObject.rigidbody.transform.position = temp;
		}
		if(gameObject.rigidbody.position.z < -12)
		{
			Vector3 temp = new Vector3(0,1,12);
			gameObject.rigidbody.transform.position = temp;
		}
	}
}
