using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
   [ SerializeField] float moveSpeed = 10f;
    [SerializeField] float rotationSpeed = 100f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        MoveCar(verticalInput);
        RotateCar(horizontalInput);
    }

    void MoveCar(float input)
    {
        Vector3 moveDirection = transform.forward * input * moveSpeed * Time.deltaTime;
        transform.Translate(moveDirection);
    }

    void RotateCar(float input)
    {
        float rotation = input * rotationSpeed * Time.deltaTime;
        transform.Rotate(0f, rotation, 0f);
    }
}


