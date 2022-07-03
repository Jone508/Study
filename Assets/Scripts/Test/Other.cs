using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Other : MonoBehaviour {

    // Use this for initialization
    void Awake()
    {
        print("-----other已注册-----");
        EventCenter.GetInstance().AddEventListener<Monster>("monster_death", GetOther);
    }

    // Update is called once per frame
    void GetOther(object info)
    {
        print("其他任务");
    }
}
