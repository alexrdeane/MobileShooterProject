using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    public float runSpeed = 0.35f;

    public bool playerInRoom1;
    public bool playerInRoom2;
    public bool playerInRoom3;

    void Start()
    {
        enemy = this.gameObject;
        player = GameObject.FindGameObjectWithTag("Player");
    }


    void Update()
    {
        EnemyMovement();
    }

    void EnemyMovement()
    {
        enemy.transform.LookAt(player.transform);
        enemy.transform.position += transform.forward * runSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

        }
    }
}
