using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using System.Collections;

public class uGUIresize : MonoBehaviour
{
    public  GameObject rawImage;
    public ParticleSystem pe;
    public GameObject thunderParticle;        //パーティクル
    public Transform[] thunderPoints;         // 地点
    float width, height;
    // Use this for initialization
    void Start()
    {
        width = 0;
        height = 0;
        pe.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            foreach (Transform explosionPos in thunderPoints)
            {
                GameObject thunder = Instantiate (thunderParticle,               // パーティクルオブジェクトの生成
                    explosionPos.position, transform.rotation) as GameObject;
                Destroy(thunder, 5f);                                             // ５秒後に消す
            }
        }
        if (Input.GetKey("down"))
        {
               height += 1;
        }
        if (height < 10)
        {
            rawImage.transform.localScale = new Vector3(
            gameObject.transform.localScale.x + height,
            gameObject.transform.localScale.y + height,
            gameObject.transform.localScale.z + height);
        }
       
    }
}