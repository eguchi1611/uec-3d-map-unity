using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    // オブジェクトを取得

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // ボールが円上を転がるようにプラットフォームを傾ける
        float radius = 0.5f; // 円の半径
        float speed = 1.0f;  // 回転速度
        float tiltStrength = 5.0f; // 傾きの強さ

        // 円上の目標点を計算
        float targetX = Mathf.Cos(Time.time * speed) * radius;
        float targetZ = Mathf.Sin(Time.time * speed) * radius;

        // ボールが目標点に向かうように傾ける
        float tiltX = -targetZ * tiltStrength; // Z座標の反対方向にX軸を傾ける
        float tiltZ = targetX * tiltStrength;  // X座標と同じ方向にZ軸を傾ける

        // 傾きを適用
        transform.rotation = Quaternion.Euler(tiltX, 0, tiltZ);
    }
}
