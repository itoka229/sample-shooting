﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionbase : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        //衝突判定
        if (collision.gameObject.tag == "base")
        {
            //相手のタグがbaseならば、自分を消す
            Destroy(this.gameObject);

        }
    }
}