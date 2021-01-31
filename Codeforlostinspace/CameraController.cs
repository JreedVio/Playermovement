using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject hero;
    float smoothSpeed = 10f;

    void Start()
    {
        hero = GameObject.Find("/Hero");
    }

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, hero.transform.position + new Vector3(0, 0, -1), smoothSpeed * Time.deltaTime);
    }
}
