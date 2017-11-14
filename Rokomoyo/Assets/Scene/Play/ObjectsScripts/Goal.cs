using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//即死トラップのスクリプト

public class Goal : Trap {

    GameObject key;
    bool goalflag = false;
    static int x = 2;
    GameObject sound;

	// Use this for initialization
	override protected void Start () {
        //基底クラスのStart関数
        base.Start();
        key = GameObject.Find("Key");
    }

    // Update is called once per frame
    override protected void Update()
    {
        //基底クラスのUpdate関数
        base.Update();

        //トラップの上にいるなら
        if (base.OnFloor() == true)
        {
            //シーン遷移する
            if (key.active == false)
            {
                Stage.ChangeStage();
            }
        }
        //いないなら
        else { }
    }
}
