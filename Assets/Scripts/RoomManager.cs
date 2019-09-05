using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public GameObject room;
    public static bool playerInRoom1;
    public static bool playerInRoom2;
    public static bool playerInRoom3;
    public Room currentRoom;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (this.currentRoom == Room.room1)
            {
                DisableRooms();
                playerInRoom1 = true;
            }
            if (this.currentRoom == Room.room2)
            {
                DisableRooms();
                playerInRoom2 = true;
            }
            if (this.currentRoom == Room.room3)
            {
                DisableRooms();
                playerInRoom3 = true;
            }
            else
            {
                DisableRooms();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (this.currentRoom == Room.room1)
            {
                DisableRooms();
            }
            if (this.currentRoom == Room.room2)
            {
                DisableRooms();
            }
            if (this.currentRoom == Room.room3)
            {
                DisableRooms();
            }
        }
    }

    void DisableRooms()
    {
        playerInRoom1 = false;
        playerInRoom2 = false;
        playerInRoom3 = false;
    }
}
public enum Room
{
    room1,
    room2,
    room3
}
