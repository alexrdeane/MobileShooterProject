using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public LayerMask doorLayerMask;
    public Transform cam;
    public int randomRoom;
    public GameObject[] rooms;
    public int randomDoor;
    public Transform[] doorsInRoom0;
    public Transform[] doorsInRoom1;
    public Transform[] doorsInRoom2;
    public Transform[] doorsInRoom3;
    public GameObject player;
    
    void Update()
    {
        
    }

    public void ChangeRoom()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.position, cam.forward, out hit, 0.3f, doorLayerMask))
        {
            randomRoom = Random.Range(0, rooms.Length);
            if (randomRoom == 0)
            {
                randomDoor = Random.Range(0, doorsInRoom0.Length);
                player.transform.position = doorsInRoom0[randomDoor].position;
                player.transform.rotation = doorsInRoom0[randomDoor].localRotation;
                Debug.Log(randomRoom);
                Debug.Log(randomDoor);
            }
            if (randomRoom == 1)
            {
                randomDoor = Random.Range(0, doorsInRoom1.Length);
                player.transform.position = doorsInRoom1[randomDoor].position;
                player.transform.rotation = doorsInRoom1[randomDoor].localRotation;
                Debug.Log(randomRoom);
                Debug.Log(randomDoor);
            }
            if (randomRoom == 2)
            {
                randomDoor = Random.Range(0, doorsInRoom2.Length);
                player.transform.position = doorsInRoom2[randomDoor].position;
                player.transform.rotation = doorsInRoom2[randomDoor].localRotation;
                Debug.Log(randomRoom);
                Debug.Log(randomDoor);
            }
            if (randomRoom == 3)
            {
                randomDoor = Random.Range(0, doorsInRoom3.Length);
                player.transform.position = doorsInRoom3[randomDoor].position;
                player.transform.rotation = doorsInRoom3[randomDoor].rotation;
                Debug.Log(randomRoom);
                Debug.Log(randomDoor);
            }
        }
    }
}
