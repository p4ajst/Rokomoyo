﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    TitleScene title = null;
    public void onClick(string objectName)
    {
        // 押されたボタンによって処理を分岐
        // ゲームスタートが押されたら
        if("GameStartButton".Equals(objectName))
        {
            // プレイシーンに移行する
            title.onClick();
        }
        else
        {
            throw new System.Exception("Not implemented!!");
        }
    }



    // Use this for initialization
    void Start ()
    {
        title = new TitleScene();
        if(title == null)
        {
            return;
        }
        title = title.GetComponent<TitleScene>();
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
