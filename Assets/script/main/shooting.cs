using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {
    // bullet prefab
    public GameObject bullet;
    // 弾丸発射点
    public Transform muzzle;
    //弾丸の速度
    public float speed = 100000;
    //score
    public int score = 0;
    //gamemaster
    private bool gamemaster;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gamemaster = GameObject.FindGameObjectWithTag("gun").GetComponent<timerscript>().gamemaster;
        score = scorescript.score;
        //制限時間以内の時
        if (gamemaster == true)
        {
                //zキーが押されたとき弾丸発射
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    //弾丸の複製
                    GameObject bullets = GameObject.Instantiate(bullet) as GameObject;

                    Vector3 force;
                    force = gameObject.transform.forward * speed;
                    //Rigidbodyに力を加えて発射
                    bullets.GetComponent<Rigidbody>().AddForce(force);
                    //弾丸の位置を調整
                    bullets.transform.position = muzzle.position;
                }

        }

    }
}
