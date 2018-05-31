using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour {

	// 
	void Start () {
		
	}
	
	// Cubeの回転
	void Update () {
        //→キーが押されたとき
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            transform.Rotate(new Vector3(0, 45, 0));
        }
        //←キーが押されたとき
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -45, 0));
        }
    }
}
