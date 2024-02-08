using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    public GameObject ButtonToEnable;
    public bool gotKey = false;
    public Toggle myToggle;

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
            myToggle.isOn = true;
            Destroy(gameObject);
        }
    }
}
