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
            if (Input.GetKey(KeyCode.RightArrow)) {
                transform.Rotate(new Vector3(0, 0.3f, 0));
            }
            //←キーが押されたとき
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(new Vector3(0, -0.3f, 0));
            }
        }
}
