using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
 

    public void Retry() 
    {
        //（""）の中に現在のーシーン名を入力する
        SceneManager.LoadScene("SampleScene");

    }
}