using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public JoyStick movementJoystick;
    public JoyStick rotationJoystick;
    public float runSpeed = 2f, rotateSpeed = 50f;

    void Start()
    {
        
    }

    void Update()
    {

        transform.position += transform.TransformDirection(new Vector3(0f, 0f, movementJoystick.Vertical) * runSpeed * Time.deltaTime);
        //transform.rotation *= Quaternion.Euler(0f , movementJoystick.Horizontal * rotateSpeed * Time.deltaTime, 0f);
        transform.rotation *= Quaternion.Euler(0f, Mathf.Abs(movementJoystick.Horizontal) > .5 ? movementJoystick.Horizontal * rotateSpeed : 0f, 0f);
    }
}
