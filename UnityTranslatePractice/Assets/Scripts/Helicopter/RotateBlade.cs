using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBlade : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed = 300.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime);
    }
}
