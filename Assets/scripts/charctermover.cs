using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charctermover : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed = 4f;
    

    Vector3 forward, right;

    bool jump = false;
    public float jumpHeight = 8f;
    public float jumpSpeed = 10f;
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
        if (Input.GetButtonDown("Jump") && !jump)
        {
            StartCoroutine(Jump());
        }

        else
        {
            Move();
        }

    }

    void Move()
    {

        // Movement speed
        Vector3 rightMovement = right * moveSpeed * Input.GetAxis("Horizontal");
        Vector3 upMovement = forward * moveSpeed * Input.GetAxis("Vertical");

        // Calculate what is forward
        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);

        // Set new position
        Vector3 newPosition = transform.position;
        newPosition += rightMovement;
        newPosition += upMovement;

        // Smoothly move the new position
        transform.forward = heading;
        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime);

    }

    IEnumerator Jump()
    {
        float originalHeight = transform.position.y;

        jump = true;
        yield return null;

        rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);

        while (transform.position.y > originalHeight)
        {
            yield return null;
        }

        jump = false;

        yield return null;

    }
}
