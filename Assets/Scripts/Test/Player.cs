using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        print("-----player已注册-----");
        EventCenter.GetInstance().AddEventListener<Monster>("monster_death",GetGold);
	}
	
	// Update is called once per frame
	void GetGold (object info) {
        print("获取奖励");
	}

    private void OnDestroy()
    {
        EventCenter.GetInstance().RemoveEventListener<Monster>("monster_death", GetGold);
    }
}
