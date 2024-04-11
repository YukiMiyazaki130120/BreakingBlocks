using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) //オブジェクトが衝突したときに
    {
        if (collision.gameObject.tag == "Ball")//相手のタグがBallなら
        {
            Destroy(this.gameObject);//自分を消す
        }            
    }
}