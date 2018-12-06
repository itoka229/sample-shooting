using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startbutton : MonoBehaviour {

    public GameObject startb;
    
    //ボタンを押したらゲーム画面に移動する。
    public void OnClick() {

            SceneManager.LoadScene("waiting");

     }
    
}
