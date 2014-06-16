using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

	bool fire = false;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetAxis("Fire1") ==1)
		{
			if(fire == false)
			{
				fire = true;
				GameObject bullet = Instantiate(Resources.Load("Bullet"),transform.position,transform.rotation) as GameObject;
			}
		}
		else
		{
			fire = false;	
		}
		
	}
}
