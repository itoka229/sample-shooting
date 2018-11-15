using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorescript : MonoBehaviour {

    public Text scoreText; //Text用変数
    public int score = 0; //スコア計算用変数
    private bool gamemaster;

    // Use this for initialization
    void Start()
    {

        score = 3;//初期スコア
        SetScore(); //初期スコアを代入して表示
    }
    // Update is called once per frame
    void Update()
    {
         gamemaster = GameObject.FindGameObjectWithTag("gun").GetComponent<timerscript>().gamemaster;
        //制限時間以内の時
        if (gamemaster == true)
        {
            //scoreが0より大きい時
            if (score > 0)
            {
                //zキーが押されたとき順番に起こる
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    score -= 1;

                    SetScore();
                }
            }
        }

      
    }
    //点数加算
    void OnCollisionEnter(Collision collision)
    {
        //制限時間以内の時
        if (gamemaster == true)
        {
            //衝突した相手のタグを参照して得点を加算する
            string yourTag = collision.gameObject.tag;

            if (yourTag == "Target1")
            {
                score += 1;
            }

            if (yourTag == "Target2")
            {
                score += 2;
            }

            if (yourTag == "Target3")
            {
                score += 3;
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

