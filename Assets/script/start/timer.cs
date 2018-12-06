using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour {

    //
    private float tmpTime;
    //右上のタイムリミット
    public Text timelimit;
    //制限時間
    public int maintime;
    //計測用
    private int time;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //制限時間を測る
        tmpTime += Time.deltaTime;
        //計算表示
        time = maintime - (int)tmpTime;
        timelimit.text = time + "";
        if (time == 0) {
            timelimit.text = "";
            SceneManager.LoadScene("ShootingScene");
        }
    }
}
