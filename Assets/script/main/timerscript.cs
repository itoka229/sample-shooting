using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerscript : MonoBehaviour {

    public GameObject text;
    public float interval;
    public float tmpTime = 0;
    public bool gamemaster;


    // Use this for initialization
    void Start()
    {
        gamemaster = true;
    }

    // Update is called once per frame
    void Update()
    {   
        //制限時間を測る
        tmpTime += Time.deltaTime;
        if (tmpTime >= interval)
        {
            // 制限時間がたった後の処理をここに書く
            gamemaster = false;
            GetComponent<shooting>().enabled = false;
            text.SetActive(true);
            
        }

    }

}
