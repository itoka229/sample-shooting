using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroybullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("DelayMethod", 2.0f);
    }
	
	// Update is called once per frame
	void Update () {
    
    }
    void DelayMethod()
    {
        Destroy(gameObject);

    }
}
