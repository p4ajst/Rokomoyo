using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StereoPlug : Gimmick {

    bool flag = false;
    GameObject obj = null;
    Notes note;
	// Use this for initialization
	void Start () {
        base.Start();
        obj = GameObject.Find("AttractSounds");
        note = obj.GetComponent<Notes>();
    }

	// Update is called once per frame
	void Update () {
        base.Update();

        //ギミックの上にいるなら
        if (base.OnFloor() == true && !flag)
        {
            Debug.Log("のってる");
            flag = true;
            //音符の種類を変える処理
            note.FlipNote();
            ////音符の種類を変える処理
            //sound.FlipNote();
        }
        //トラップから抜けたら
        else if (base.OnFloor() == false)
        {
            flag = false;
            //Debug.Log("当たっていません");
        }
        //if(flag)
        //{

        //    Debug.Log("はーんてぇーんっ！");
        //}
    }
}
