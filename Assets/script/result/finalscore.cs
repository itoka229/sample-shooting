using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalscore : MonoBehaviour {

    private int score;
    public Text textscore;

    /// <summary>
    /// スコアを参照し、表示します。
    /// </summary>
	void Start () {
        score = scorescript.score;
        textscore.text = "あなたのスコアは" + score + "です!";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
