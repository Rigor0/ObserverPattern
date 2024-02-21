using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    private float _horizontal;
    private float _vertical;

    private float _movementSpeed = 5f;

    void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(_horizontal * _movementSpeed * Time.deltaTime,0 , _vertical * _movementSpeed * Time.deltaTime);
    }
}
