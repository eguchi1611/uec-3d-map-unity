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
        float tiltSpeed = 15f; // Degrees per second
        float maxTiltAngle = 10f;

        Vector3 currentRotation = transform.rotation.eulerAngles;
        float currentXAngle = currentRotation.x;
        if (currentXAngle > 180) currentXAngle -= 360;

        float currentZAngle = currentRotation.z;
        if (currentZAngle > 180) currentZAngle -= 360;

        // WASDキーで傾ける
        if (Input.GetKey(KeyCode.W))
        {
            float newXAngle = currentXAngle + tiltSpeed * Time.deltaTime;
            if (newXAngle > maxTiltAngle)
                newXAngle = maxTiltAngle;

            transform.rotation = Quaternion.Euler(newXAngle, currentRotation.y, currentRotation.z);
        }

        if (Input.GetKey(KeyCode.S))
        {
            float newXAngle = currentXAngle - tiltSpeed * Time.deltaTime;
            if (newXAngle < -maxTiltAngle)
                newXAngle = -maxTiltAngle;

            transform.rotation = Quaternion.Euler(newXAngle, currentRotation.y, currentRotation.z);
        }

        if (Input.GetKey(KeyCode.A))
        {
            float newZAngle = currentZAngle + tiltSpeed * Time.deltaTime;
            if (newZAngle > maxTiltAngle)
                newZAngle = maxTiltAngle;


            transform.rotation = Quaternion.Euler(currentRotation.x, currentRotation.y, newZAngle);
        }

        if (Input.GetKey(KeyCode.D))
        {
            float newZAngle = currentZAngle - tiltSpeed * Time.deltaTime;
            if (newZAngle < -maxTiltAngle)
                newZAngle = -maxTiltAngle;

            transform.rotation = Quaternion.Euler(currentRotation.x, currentRotation.y, newZAngle);
        }
    }
}
