using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplatformy : MonoBehaviour
{
    /// <summary>The objects initial position.</summary>
    private Vector3 startPosition;
    /// <summary>The objects updated position for the next frame.</summary>
    private Vector3 newPosition;

    /// <summary>The speed at which the object moves.</summary>
    [SerializeField] private float speed = 1;
    /// <summary>The maximum distance the object may move in either y direction.</summary>
    [SerializeField] private float maxDistance = 1;

    void Start()
    {
        startPosition = transform.position;
        newPosition = transform.position;
    }

    void Update()
    {
        newPosition.y = startPosition.y + (maxDistance * Mathf.Sin(Time.time * speed));
        transform.position = newPosition;
    }
    /// change x to y to change axis
}
