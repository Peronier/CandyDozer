using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject candyPrefab;
    public float shotForce;
    public float shotTorque;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) Shot();
    }

    public void Shot()
    {
        //プレハブからCandyオブジェクトを生成
        GameObject candy = Instantiate(
            candyPrefab,
            transform.position,
            Quaternion.identity
            );

        //CandyオブジェクトのRigidbodyを取得し力と回転を加える
        Rigidbody candyRigidbody = candy.GetComponent<Rigidbody>();
        candyRigidbody.AddForce(transform.forward * shotForce);
        candyRigidbody.AddTorque(new Vector3(0, shotTorque, 0));
    }
    //https://learning.unity3d.jp/series/yasuhara_math/ unity公式の数学学習動画
}
