using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backbutton : MonoBehaviour {
    
    //ボタンを押したらゲーム画面に移動する。
    public void OnClick()
    {

        SceneManager.LoadScene("OpeningScene");

    }
}
