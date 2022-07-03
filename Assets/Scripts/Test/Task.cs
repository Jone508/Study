using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour {

    // Use this for initialization
    void Awake()
    {
        print("-----task已注册-----");
        EventCenter.GetInstance().AddEventListener<Monster>("monster_death", GetTask);
    }

    // Update is called once per frame
    void GetTask(object info)
    {
        print("完成任务,获得经验" + (info as Monster).exp);
    }
}
