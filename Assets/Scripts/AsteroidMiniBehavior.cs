using UnityEngine;
using System.Collections;

public class AsteroidMiniBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.Rotate(0,Random.Range(-180,180),0);
			
		
		
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.velocity = Vector3.zero;
		
		rigidbody.AddRelativeForce(new Vector3(0,0,200));
	
	}
	
	void OnTriggerEnter(Collider col)
	{
		if(col.collider.name == "Player")
		{
			CtrlScript.HP -= 1;	
			if(CtrlScript.HP == 0)
			{
				Destroy(col.gameObject);
				Destroy(gameObject);
				CtrlScript.lifes -=1;
				Application.LoadLevel(Application.loadedLevel);
			}
		}
		
		
		
		if(col.collider.name == "Bullet(Clone)")
		{
			Destroy(col.gameObject);
			Destroy(gameObject);
		}
		
	}
}
