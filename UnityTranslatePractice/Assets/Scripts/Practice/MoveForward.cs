using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _destroyTime;
    
    private void Awake()
    {
        // 처음에 나오고 삭제 준비
        Destroy(GameObject,_destroyTime);   
    }

    // Update is called once per frame
    private void Update()
    {
        MoveForward();
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
    }
}
