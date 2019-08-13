using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public JoyStick movementJoystick;
    public JoyStick rotationJoystick;
    public float runSpeed = 2f, rotateSpeed = 50f;

    public Transform cam;

    Vector3 rot;

    void Start()
    {

    }

    void Update()
    {
        rot += new Vector3(-rotationJoystick.Vertical, rotationJoystick.Horizontal, 0f) * rotateSpeed * Time.deltaTime;
        rot.x = Mathf.Clamp(rot.x, -90f, 90f);
        transform.position += transform.TransformDirection(new Vector3(movementJoystick.Horizontal, 0f, movementJoystick.Vertical) * runSpeed * Time.deltaTime);
        //transform.rotation *= Quaternion.Euler(0f , movementJoystick.Horizontal * rotateSpeed * Time.deltaTime, 0f);
        transform.rotation = Quaternion.Euler(0f, rot.y, 0f);
        cam.localRotation = Quaternion.Euler(rot.x, 0f, 0f);
    }


}
