using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        InputMgr.GetInstance().StartOrEndCheck(true);
        EventCenter.GetInstance().AddEventListener<KeyCode>("某键按下", (key) => 
        {
            if (key == KeyCode.W)
                print("======= W =======+++123");
        });
	}
}
