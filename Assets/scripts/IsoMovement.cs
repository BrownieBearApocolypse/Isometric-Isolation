using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class IsoMovement : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed = 4f;
    Vector3 forward, right;
    Rigidbody rb;
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded;
       

    void OnCollisionStay()
    {
        isGrounded = true;
    }    

    // Use this for initialization
    void Start()
    {
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);

        // -45 degrees from the world x axis
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
       

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void Move()
    {
        // Movement speed
        Vector3 rightMovement = right * moveSpeed * Input.GetAxisRaw("Horizontal");
        Vector3 upMovement = forward * moveSpeed * Input.GetAxisRaw("Vertical");
        float HAX = Input.GetAxisRaw("Horizontal");
        float VAX = Input.GetAxisRaw("Vertical");
       

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

    
}


