using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{
    Vector3 startPosition;

    public float amplitude;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //変位を計算
        float z = amplitude * Mathf.Sin(Time.time * speed);

        //zを変位させたポジションに再設定
        transform.localPosition = startPosition + new Vector3(0, 0, z);
    }
    //https://tech-camp.in/note/technology/93350/#i-4 プログラミングで必要な数学知識が学べる教則本
}
