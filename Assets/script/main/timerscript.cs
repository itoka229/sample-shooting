using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            StartCoroutine("Changescene");



        }

    }
    IEnumerator Changescene(){
        yield return new WaitForSeconds(1f);
        // 現在のシーンを再読込する
        SceneManager.LoadScene("result");
    }

}
