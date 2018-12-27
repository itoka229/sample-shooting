using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorescript2 : MonoBehaviour {


    public Text scoreText; //Text用変数
    private GameObject gamemaster;
    // Use this for initialization
    void Start()
    {
        gamemaster = GameObject.FindGameObjectWithTag("gun");
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
                scorescript.score += 30;
                gamemaster.GetComponent<timerscript>().tmpTime -= 10;
            }

            if (yourTag == "Target2")
            {
               scorescript.score += 60;
            }

            if (yourTag == "Target3")
            {
                scorescript.score += 90;
            }
            if (yourTag == "barrel")
            {
                scorescript.score += 0;
            }

            SetScore();
        }

    }

    void SetScore()
    {
        //スコアの再表示
        scoreText.text = string.Format("Score:{0}", scorescript.score);
    }
}
