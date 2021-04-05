using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationArroundSun : MonoBehaviour
{
    public float radius = 5;
    public float speed = 2;
    public float angle = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 v3 = Vector3.zero;
        angle += speed * Time.deltaTime;

        v3.x = radius * Mathf.Cos(angle);
        v3.z = radius * Mathf.Sin(angle);
        transform.position = v3;
    }
}