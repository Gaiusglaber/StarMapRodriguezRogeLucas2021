using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveCamera : MonoBehaviour
{
    public float speed;
    #region DEAFAULTPOSITION
    const float DEFAULTXPOSITION = 563;
    const float DEFAULTYPOSITION = 847;
    const float DEFAULTZPOSITION = -1293;
    #endregion
    #region DEFAULTROTATION
    const float DEFAULTXROTATION = 33.602f;
    const float DEFAULTYROTATION = 0.0f;
    const float DEFAULTZROTATION = 0.0f;
    #endregion
    #region PLANETS
    public GameObject mercury;
    public GameObject venus;
    public GameObject earth;
    public GameObject mars;
    public GameObject jupiter;
    public GameObject saturn;
    public GameObject uranus;
    public GameObject neptune;
    #endregion
    private Vector3 positionTransform=Vector3.zero;
    private float rotationTransform = 0.0f;
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F1))
        {
            positionTransform = mercury.transform.position;
            rotationTransform = mercury.transform.rotation.y;
            transform.position = new Vector3(positionTransform.x,0,positionTransform.z);
            transform.Rotate(0, speed * Time.deltaTime, 0,Space.Self);
        }
        else if (Input.GetKey(KeyCode.F2))
        {
            positionTransform = venus.transform.position;
            positionTransform.x += venus.transform.localScale.x * 2;
            positionTransform.y += venus.transform.localScale.y * 2;
            rotationTransform = venus.transform.rotation.y;
            transform.position = positionTransform;
            transform.Rotate(DEFAULTXROTATION, rotationTransform, DEFAULTZPOSITION);
        }
        else if (Input.GetKey(KeyCode.F3))
        {
            positionTransform = earth.transform.position;
            positionTransform.x += earth.transform.localScale.x * 2;
            positionTransform.y += earth.transform.localScale.y * 2;
            rotationTransform = earth.transform.rotation.y;
            transform.position = positionTransform;
            transform.Rotate(DEFAULTXROTATION, rotationTransform, DEFAULTZPOSITION);
        }
        else if (Input.GetKey(KeyCode.F4))
        {
            positionTransform = mars.transform.position;
            positionTransform.x += mars.transform.localScale.x * 2;
            positionTransform.y += mars.transform.localScale.y * 2;
            rotationTransform = mars.transform.rotation.y;
            transform.position = positionTransform;
            transform.Rotate(DEFAULTXROTATION, rotationTransform, DEFAULTZPOSITION);
        }
        else if (Input.GetKey(KeyCode.F5))
        {
            positionTransform = jupiter.transform.position;
            positionTransform.x += jupiter.transform.localScale.x * 2;
            positionTransform.y += jupiter.transform.localScale.y * 2;
            rotationTransform = jupiter.transform.rotation.y;
            transform.position = positionTransform;
            transform.Rotate(DEFAULTXROTATION, rotationTransform, DEFAULTZPOSITION);
        }
        else if (Input.GetKey(KeyCode.F6))
        {
            positionTransform = saturn.transform.position;
            positionTransform.x += saturn.transform.localScale.x * 2;
            positionTransform.y += saturn.transform.localScale.y * 2;
            rotationTransform = saturn.transform.rotation.y;
            transform.position = positionTransform;
            transform.Rotate(DEFAULTXROTATION, rotationTransform, DEFAULTZPOSITION);
        }
        else if (Input.GetKey(KeyCode.F7))
        {
            positionTransform = uranus.transform.position;
            positionTransform.x += uranus.transform.localScale.x * 2;
            positionTransform.y += uranus.transform.localScale.y * 2;
            rotationTransform = uranus.transform.rotation.y;
            transform.position = positionTransform;
            transform.Rotate(DEFAULTXROTATION, rotationTransform, DEFAULTZPOSITION);
        }
        else if (Input.GetKey(KeyCode.F8))
        {
            positionTransform = neptune.transform.position;
            positionTransform.x += neptune.transform.localScale.x * 2;
            positionTransform.y += neptune.transform.localScale.y * 2;
            rotationTransform = neptune.transform.rotation.y;
            transform.position = positionTransform;
            transform.Rotate(DEFAULTXROTATION, rotationTransform, DEFAULTZPOSITION);
        }
        else
        {
            transform.rotation = new Quaternion(0.33f,DEFAULTYROTATION,DEFAULTZROTATION,(float)Space.Self);
            transform.position = new Vector3(DEFAULTXPOSITION,DEFAULTYPOSITION,DEFAULTZPOSITION);
        }
    }
}
