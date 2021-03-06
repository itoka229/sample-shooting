﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorescript : MonoBehaviour {

    public Text scoreText; //Text用変数
    public static int score = 0; //スコア計算用変数
    private GameObject gamemaster;

    // Use this for initialization
    void Start()
    {

        score = 30;//初期スコア
        SetScore(); //初期スコアを代入して表示
         gamemaster = GameObject.FindGameObjectWithTag("gun");
    }
    // Update is called once per frame
    void Update()
    {

        //制限時間以内の時
        if (gamemaster.GetComponent<timerscript>().gamemaster == true)
        {
            //scoreが0より大きい時
            if (score > 0)
            {
                //zキーが押されたとき順番に起こる
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    score -= 10;

                    SetScore();
                }
            }
        }

      
    }
    //点数加算
    void OnCollisionEnter(Collision collision)
    {
        //制限時間以内の時
        if (gamemaster.GetComponent<timerscript>().gamemaster == true)
        {
            //衝突した相手のタグを参照して得点を加算する
            string yourTag = collision.gameObject.tag;

            if (yourTag == "Target1")
            {
                score += 10;
                gamemaster. GetComponent<timerscript>().tmpTime -= 5;
            }

            if (yourTag == "Target2")
            {
                score += 20;
            }

            if (yourTag == "Target3")
            {
                score += 30;
            }
            if (yourTag == "barrel")
            {
                score += 0;
            }

            SetScore();
        }

    }

    void SetScore()
    {
        //スコアの再表示
        scoreText.text = string.Format("Score:{0}", score);
    }
}

