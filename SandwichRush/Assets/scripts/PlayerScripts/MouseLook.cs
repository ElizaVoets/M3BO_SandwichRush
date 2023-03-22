using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    public Transform playerBody;

    float xRot = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        //gets mouse movement
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        //time

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -90f, 90f);


        //Y rotation
        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        //mouse X (left - right)
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
