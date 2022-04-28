using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour
{
    public int LockCount;
    public int UnlockedCount;

    public bool Lock;
    public GameObject teleport2;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        Lock = true;
    }

    public void LockCheck()
    {
        if (UnlockedCount == LockCount)
        {
            Lock = false;
             
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (Lock == false)
            player.transform.position = teleport2.transform.position;
    }

}
