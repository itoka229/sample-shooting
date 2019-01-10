using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour {

    public GameObject exp;
    public float size;
    public int power;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        
    }
    
    
    void OnCollisionEnter(Collision collision)
    {
        //衝突判定
        if (collision.gameObject.tag == "bullet")
        {
            //相手のタグがbulletならば、爆発し自分を消す
            //爆発するものの生成
            GameObject bomb = Instantiate(exp, transform.position + new Vector3(0,15,0), Quaternion.identity);
            bomb.transform.localScale = size * Vector3.one;
            //coliderを設定
            var collider = bomb.AddComponent<SphereCollider>();
            collider.isTrigger = true;
            //colliderの半径を定義
            collider.radius = size;
            //爆発判定用のスクリプトを追加&爆発の威力を定義
            bomb.AddComponent<rigidexplosion>().power = power;
            Destroy(this.gameObject);

        }
    }
}
