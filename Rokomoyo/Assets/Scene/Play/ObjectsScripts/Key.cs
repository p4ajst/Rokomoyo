using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Trap {

	// Use this for initialization
	void Start () {
        base.Start();
	}
	
	// Update is called once per frame
	void Update () {
        base.Update();
        if (OnFloor())
            Destroy(gameObject);
	}
}
