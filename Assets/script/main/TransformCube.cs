using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var guntransform = transform.position;
        //上限
        if(guntransform.y < 13)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position += new Vector3(0, 0.1f, 0);
            }
        }
        //下限
        if (guntransform.y > -4)
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position += new Vector3(0, -0.1f, 0);
            }
        }

	}
}
