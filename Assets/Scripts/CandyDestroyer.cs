using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyDestroyer : MonoBehaviour
{
    public CandyManager candyManager;
    public int reward;
    public GameObject effectPrehab;
    public Vector3 effectRotation;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Candy")
        {
            //指定数だけCandyのストックを増やす
            candyManager.AddCandy(reward);

            //オブジェクトの削除
            Destroy(other.gameObject);

            if(effectPrehab != null)
            {
                //Candyのポジションにエフェクトを生成
                Instantiate(
                    effectPrehab,
                    other.transform.position,
                    Quaternion.Euler(effectRotation)
                    );
            }
        }
    }
}
