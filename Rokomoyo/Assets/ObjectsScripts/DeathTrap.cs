using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//即死トラップのスクリプト

public class DeathTrap : Trap {

    //（空の）スタートオブジェクトを取得するためのGameObject型の変数
    GameObject start;

	// Use this for initialization
	override protected void Start () {
        //基底クラスのStart関数
        base.Start();

        //スタートオブジェクトを取得する
        start = GameObject.Find("Start/Start");
    }

    // Update is called once per frame
    override protected void Update()
    {
        //基底クラスのUpdate関数
        base.Update();

        //デバッグ用
        Debug.Log(gameObject.transform.position.z);
        Debug.Log("Playerのｘ座標" + pos_x);
        Debug.Log("PlayerのZ座標" + pos_z);

        //トラップの上にいるなら
        if (base.OnFloor() == true)
        {
            Debug.Log("当たっています");

            //プレイヤーの座標をスタートの座標にする
            player.transform.position = start.transform.position;
        }
        //いないなら
        else
            Debug.Log("当たっていません");
            //何もしない
    }
}
