using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plug : Gimmick {

	// Use this for initialization
	void Start () {
        base.Start();
	}
	
	// Update is called once per frame
	void Update () {
        base.Start();

        //ギミックの上にいるなら
        if (base.OnFloor() == true)
        {
            //Debug.Log("当たっています");

            //プレイヤーの充電を回復する
            player.GetComponent<test>().battery += 1.0f/30.0f;
        }
        //トラップから抜けたら
        else if (base.OnFloor() == false)
        {
            //Debug.Log("当たっていません");
        }
    }
}
