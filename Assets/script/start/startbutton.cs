﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startbutton : MonoBehaviour {

    //ボタンを押したらゲーム画面に移動する。
    public void OnClick()
    {

        SceneManager.LoadScene("waiting");

    }
    void Update()
    {
    if(Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene("waiting");
        }
    }


}

