using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createObject : MonoBehaviour {

    public GameObject[] Train;
    [SerializeField]
    private float interval = 10f;
    [SerializeField]
    private float tmpTime = 0;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        tmpTime += Time.deltaTime;
        if (tmpTime >= interval)
        {
            int number;

             // n秒ごとに行いたい処理をここに書く
            number = Random.Range(0, Train.Length);
            Instantiate(Train[number], new Vector3(50.0f, 1.25f, 30.0f), Quaternion.identity);
            tmpTime = 0;
        }
       
    }
 
}
