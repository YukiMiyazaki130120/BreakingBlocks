using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottom : MonoBehaviour
{
    public GameObject gameovertext;
    public GameObject retrybutton;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
          
            retrybutton.SetActive(true);
            gameovertext.SetActive(true);
            Destroy(collision.gameObject);
        }
    }
}