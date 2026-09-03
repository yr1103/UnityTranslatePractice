using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    void Update()
    {
       Move();
    }

    private void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(x, 0, z);
        movement = movement.normalized;
        transform.Translate(movement * _moveSpeed * Time.deltaTime);
    }



}
