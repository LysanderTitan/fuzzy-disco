using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float minX;
    public float maxX;

    void Update()
    {
        float x = Mathf.Clamp(transform.position.x, minX, maxX);
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
