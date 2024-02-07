using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject ButtonToEnable;
    public bool gotKey = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gotKey = true;
            ButtonToEnable.GetComponent<BoxCollider>().enabled = true;
            //Lockcheck takes place at button.
            Debug.Log("Keyhas");

            Destroy(gameObject);
        }
    }
}
