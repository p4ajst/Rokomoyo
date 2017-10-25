﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//トラップ（即死、液漏れ）の基底クラス

public class Trap : MonoBehaviour{

    //プレイヤーの座標を保存する（ｘ、ｙのみ）
    protected float pos_x;
    protected float pos_z;

    //プレイヤーオブジェクトを取得するためのGameObject型の変数
    protected GameObject player;

    // Use this for initialization
    virtual protected void Start () {
        //プレイヤーオブジェクトを取得する
        player = GameObject.Find("Player");
    }

    //プレイヤーが同じ座標にいるかチェックする
    public bool OnFloor()
    {
        //プレイヤーの座標を取得する
        pos_x = player.transform.position.x;
        pos_z = player.transform.position.z;

        //当たり判定を取る
        if (gameObject.transform.position.x - 0.5 < pos_x + 0.5 &&
            gameObject.transform.position.x + 0.5 > pos_x - 0.5 &&
            gameObject.transform.position.z - 0.5 < pos_z + 0.5 &&
            gameObject.transform.position.z + 0.5 > pos_z - 0.5)
        {
            //当たっていたらtrueを返す
            return true;
        }
        //当たっていなかったらfalseを返す
        return false;
    }

    // Update is called once per frame
    virtual protected void Update () {
        //座標チェックを毎フレーム行う
        OnFloor();
    }
}
