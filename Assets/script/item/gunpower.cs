using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunpower : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {

    }
    //弾の威力を定義
    public int power;
    //侵入判定
    private void OnCollisionEnter(Collision other)
    {
        //判定した相手にRigidbodyがあるとき
        if (other.gameObject.GetComponent<Rigidbody>() != null)
        {
            //力を加える
            var direction =GetComponent<Rigidbody>().velocity;
            //弾の位置
            var bulletvector = GetComponent<Transform>().position;
            direction = direction / (Vector3.Magnitude(direction));
            other.gameObject.GetComponent<Rigidbody>().AddForceAtPosition(power * direction,transform.position+bulletvector);
            Destroy(this.gameObject);
        }
    }
}
