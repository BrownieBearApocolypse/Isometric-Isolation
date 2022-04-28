using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerFinalDoor : MonoBehaviour
{
    public GameObject Door;
    public bool Triggered;
    public int level = 0;

    // Start is called before the first frame update
    void Start()
    {
        Triggered = false;
    }

    // Update is called once per frame


    public void OnTriggerEnter(Collider other)
    {
        if (Triggered == false && other.gameObject.tag == "Player")
        {
            Triggered = true;
            SceneManager.LoadScene(level);
        }

        
    }

    

}