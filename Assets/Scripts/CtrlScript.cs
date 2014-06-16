using UnityEngine;
using System.Collections;

public class CtrlScript : MonoBehaviour {
	public static int lifes = 3;
	public static int HP = 10;
	
	GUIText playerLifeDisplay;
	GUIText playerHpDisplay;
		
	void Start () {
		for(int i = 0; i < 4; i++)
		{
			Vector3 aspos = new Vector3(Random.Range(-10,10),0,Random.Range(-10,10));
			GameObject astro = Instantiate(Resources.Load("Asteroid"),aspos,Quaternion.identity) as GameObject;	
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Debug.Log(HP);
		Debug.Log(lifes);
		playerLifeDisplay.text = lifes.ToString();
		playerHpDisplay.text = HP.ToString();
	}
}
