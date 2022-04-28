using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{

    public GameObject objectToMove;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            objectToMove.GetComponent<Animator>().SetTrigger("BookTrigger");
        }
    }
}
