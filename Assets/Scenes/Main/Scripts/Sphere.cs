using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    GameObject sphereObj;

    Vector3 initialPosition = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        if (prefab != null)
        {
            Debug.Log("Instantiate");
            sphereObj = Instantiate(prefab, initialPosition, Quaternion.identity);
        }
        else
        {
            Debug.Log("gameObject is null");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (sphereObj.transform.position.y < -5)
        {
            sphereObj.transform.position = initialPosition;
        }
    }
}
