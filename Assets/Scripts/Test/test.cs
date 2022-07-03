using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}

    //IEnumerator TestIEnumerator()
    //{
    //    yield return new WaitForSeconds(1f);
    //    Debug.Log("new pool testting");
    //}

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            //
            PoolMgr.GetInstance().GetObj("Prefabs/Cube", (obj) =>
            {
                obj.transform.localScale = Vector3.one * 2;
            });
        }

        if (Input.GetMouseButtonDown(1))
        {
            PoolMgr.GetInstance().GetObj("Prefabs/Sphere", (obj) =>
                {
                    print(obj.name);
                });
        }
    }

    //public void TUDO(GameObject obj)
    //{
    //    print(obj.name);
    //}
}
