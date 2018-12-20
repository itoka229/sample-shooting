using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startallowmoving : MonoBehaviour {

    public GameObject upallow;//上キー
    public GameObject downallow;//下キー

    // Use this for initialization
    void Start () {
        upallow.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //矢印の判定
            bool upallowreference = upallow.activeSelf;//上矢印の表示状態
            if (upallowreference == true)
            {
                upallow.SetActive(false);
                downallow.SetActive(true);
            }
            else
            {
                upallow.SetActive(true);
                downallow.SetActive(false);

            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //矢印の判定
            bool upallowreference = upallow.activeSelf;//上矢印の表示状態
            if (upallowreference == true)
            {
                upallow.SetActive(false);
                downallow.SetActive(true);
            }
            else
            {
                upallow.SetActive(true);
                downallow.SetActive(false);

            }
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            bool upallowreference = upallow.activeSelf;
            if (upallowreference == true)
            {
                SceneManager.LoadScene("waiting");
            }
            else
            {
                SceneManager.LoadScene("OpeningScene");
            }
        }
    }
}
