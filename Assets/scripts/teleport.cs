using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{

    public GameObject teleport2;
    public GameObject player;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            player.transform.position = other.transform.position;
    }
}