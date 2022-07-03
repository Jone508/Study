using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {

	public float exp = 100;
	// Use this for initialization
	void Start () {
		print("*-----is Death-----*");
		Death();
		
	}
	
	// Update is called once per frame
	void Death () 
	{
        EventCenter.GetInstance().EventTrigger("monster_death", this);
	}
}
