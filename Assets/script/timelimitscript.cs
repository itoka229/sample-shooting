using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timelimitscript : MonoBehaviour {
    //gun
    public GameObject rifle;
    //右上のタイムリミット
    public Text timelimit;
    //制限時間
    public int maintime;
    //計測用
    private int time;
    //gamemaster
    private bool gamemaster;
	// Use this for initialization
	void Start () {
        maintime = (int)GameObject.FindGameObjectWithTag("gun").GetComponent<timerscript>().interval;
	}
	
	// Update is called once per frame
	void Update () {
        gamemaster = rifle.GetComponent<timerscript>().gamemaster;
        if (gamemaster == true)
        {
            //今の経過時間を参照
            int tmptime = (int)rifle.GetComponent<timerscript>().tmpTime;
            //計算表示
            time = maintime - tmptime;
            timelimit.text = time + "";
        }
        if (gamemaster == false)
        {
            timelimit.text = "";
        }

	}
}
