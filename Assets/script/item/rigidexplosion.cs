using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidexplosion : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //このスクリプトを1.0秒後に消去
        Invoke("a",1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //爆発の威力を定義
    public int power;
    //侵入判定
    private void OnTriggerEnter(Collider other)
    {
        //判定した相手にRigidbodyがあるとき
        if (other.gameObject.GetComponent<Rigidbody>() != null)
        {
            //
            var direction = other.transform.position - transform.position;
            direction = direction / (Vector3.Magnitude(direction) *Vector3.Magnitude(direction));
            other.gameObject.GetComponent<Rigidbody>().AddForce(power*direction);
        }
    }
    private void a()
    {
        Destroy(this);
    }
}
