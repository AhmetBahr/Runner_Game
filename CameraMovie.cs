using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovie : MonoBehaviour
{
    private Transform lookAt;
    public Vector3 offSet;
    private void Start()
    {
        lookAt = GameObject.FindGameObjectWithTag("Player").transform;
        offSet = transform.position - lookAt.position;
    }
    private void Update()
    {
        transform.position = lookAt.position + offSet;
    }
}
