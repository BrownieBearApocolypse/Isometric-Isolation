﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    public GameObject Door;
    public bool Triggered;

    // Start is called before the first frame update
    void Start()
    {
        Triggered = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (Triggered == false && other.gameObject.tag == "Player")
        {
            Triggered = true;
            Door.GetComponent<DoorLock>().UnlockedCount++;
            Door.GetComponent<DoorLock>().LockCheck();
            Debug.Log("we ballin");
        }
    }

}
