using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public LayerMask door;
    public Transform cam;
    void Update()
    {
        
    }

    public void ChangeRoom()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.position, cam.forward, out hit, 0.3f, door))
        {
            Debug.Log("ye");
        }
    }
}
