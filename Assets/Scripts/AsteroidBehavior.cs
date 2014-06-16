using UnityEngine;
using System.Collections;

public class AsteroidBehavior : MonoBehaviour {

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
			CtrlScript.lifes -= 1;
			Destroy(col.gameObject);
			Destroy(gameObject);
			Application.LoadLevel(Application.loadedLevel);
		}
		
		
		
		if(col.collider.name == "Bullet(Clone)")
		{
			Destroy(col.gameObject);
			for(int i = 0; i < 2; i++)
			{
				GameObject astro = Instantiate(Resources.Load("Asteroidmini"), transform.position,Quaternion.identity) as GameObject;
			}
			Destroy(gameObject);
		}
		
		if(col.collider.name == "Bullet(Clone)")
		{
			Destroy(col.gameObject);
			Destroy(gameObject);
		}
		
	}
}
