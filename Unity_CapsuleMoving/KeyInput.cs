using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour
{

    private float _speed = 6.0f;
    private CharacterController _controller;
    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent <CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float gravity = -9.8f;
        float deltaX = Input.GetAxis("Horizontal") * _speed;
        float deltaZ = Input.GetAxis("Vertical") * _speed;

        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, _speed);
        movement.y = gravity;
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _controller.Move(movement);
    }
}
