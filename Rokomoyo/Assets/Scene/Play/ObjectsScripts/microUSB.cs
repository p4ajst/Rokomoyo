﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class microUSB : Gimmick {

    //踏んでいるか確認のフラグ
    bool flag = false;
    
	// Use this for initialization
	void Start () {
        base.Start();

        //deathTrap = GameObject.Find("DeathTrap");
	}
	
	// Update is called once per frame
	void Update () {
        base.Update();

        //踏んでいたら
        if (base.OnFloor())
        {
            //フラグを立てる
            flag = true;
        }
	}

    //フラグ確認用
    public bool GetFlag()
    {
        return flag;
    }
}
