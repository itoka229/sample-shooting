using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class gameoff : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Backspace))
        {
            EditorApplication.isPlaying = false;
        }
    }
}
