using UnityEngine;
using System.Collections;

public class DetectPlayer : MonoBehaviour
{

    UnityEngine.AI.NavMeshAgent agent;
    public Transform target;
    public GameObject Player;
    public bool follow = false;

    public UnityEngine.AI.NavMeshAgent Agent { get => agent; set => agent = value; }

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (follow == true)
        {
            agent.SetDestination(target.position);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        //checking if player collides with trigger
        if (col.GetComponent<Collider>().tag == Player.tag)
        {
            follow = true;
        }
    }
}