using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class charctermover : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed = 4f;


    Vector3 forward, right;

    //bool jump = false;
   // public float jumpHeight = 8f;
    //public float jumpSpeed = 10f;
    Rigidbody rb;

    // Use this for initialization
    void Start()
    {

        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);

        // -45 degrees from the world x axis
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        else
        {
            Move();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    void Move()
    {
        
        // Movement speed
        Vector3 rightMovement = right * moveSpeed * Input.GetAxisRaw("Horizontal");
        Vector3 upMovement = forward * moveSpeed * Input.GetAxisRaw("Vertical");
        float HAX = Input.GetAxisRaw("Horizontal");
        float VAX = Input.GetAxisRaw("Vertical");
        Debug.Log("Hax: " + HAX + " VAX: " + VAX);

        // Calculate what is forward
        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);

        //Debug.Log("RM: " + rightMovement + "UM: " + upMovement);

        // Set new position
        Vector3 newPosition = transform.position;
        newPosition += rightMovement;
        newPosition += upMovement;

        // Smoothly move the new position
        transform.forward = heading;
        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime);
        
        rightMovement = Vector3.zero;
        upMovement = Vector3.zero;


    }

    void Jump()
    {

    }
    
}
