using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float _upSpeed;
    [SerializeField] private float _downSpeed;

    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;

    //플레이어 키입력에 따라 앞뒤양옆 상하좌우 이동가능하게

    private void Update()
    {
        Vector3 movement = GetMovement();
        Move(movement);
        PlayerRotate(movement);
        MoveUp();
        MoveDown();

    }

    private void MoveUp()
    {
        
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.up * _upSpeed * Time.deltaTime);
        }
    }

    private void MoveDown()
    {
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.down * _downSpeed * Time.deltaTime);
        }
    }

    private void Move(Vector3 movement)
    {
        
        if (movement == Vector3.zero)
        {
            return;
        }

        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
    }

    private Vector3 GetMovement()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(x, 0, z);
        return movement.normalized;
    }

    private void PlayerRotate(Vector3 movement)
    {
        if (movement == Vector3.zero)
        {
            return;
        }

        Quaternion look = Quaternion.LookRotation(movement);

        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            look,
            _rotateSpeed * Time.deltaTime            
        );

    }


}
