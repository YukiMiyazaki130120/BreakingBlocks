using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //ボールの速度
    public float speed = 5f;
   
    Rigidbody2D myRigidbody;

    void Start()
    {  
        //ボールを動かす
        myRigidbody = GetComponent<Rigidbody2D>();
        myRigidbody.velocity = new Vector3(speed, speed, 0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}