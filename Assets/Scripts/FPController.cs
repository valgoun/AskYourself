using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPController : MonoBehaviour
{

    public float Speed;
    public float RotationSpeed;

    private CharacterController _controller;
    private Transform _camera;
    private Transform _transform;


    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
        _transform = transform;
        _camera = _transform.GetChild(0);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float deltaTime = Time.deltaTime;

        _transform.Rotate(transform.up, Input.GetAxis("Mouse X") * RotationSpeed * deltaTime);
        _camera.Rotate(-Input.GetAxis("Mouse Y") * RotationSpeed * deltaTime, 0, 0, Space.Self);

        _controller.SimpleMove(transform.right * Input.GetAxis("Horizontal") * Speed + transform.forward * Input.GetAxis("Vertical") * Speed);
    }
}
