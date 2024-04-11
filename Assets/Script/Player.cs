using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
　　//プレイヤーの移動速度
    public float PlayerSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   //右矢印を押している間右に動かす
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(0.05f*PlayerSpeed, 0, 0);
        }
        //左矢印を押している間左に動かす
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-0.05f*PlayerSpeed, 0, 0);
        }
    }
}
