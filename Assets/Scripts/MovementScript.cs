using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public JoyStick movementJoystick;
    public JoyStick rotationJoystick;

    void Start()
    {
        
    }

    void Update()
    {

        transform.position += transform.TransformDirection(new Vector3(0f, 0f, movementJoystick.Vertical) * 2f * Time.deltaTime);
        transform.rotation *= Quaternion.Euler(0f , Mathf.Abs(movementJoystick.Horizontal) > .5 ? movementJoystick.Horizontal : 0f, 0f);
    }
}
