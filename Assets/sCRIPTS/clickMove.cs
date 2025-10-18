using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector3 targetPosition;
    public float moveSpeed = 5;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
    
    }
    // Update is called once per frame
    void Update()
    {
        // Check if the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Get the mouse position in screen coordinates


            // Convert screen coordinates to world coordinates
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // Keep the same Y position as the character
        }

        // Move towards the target position
        Vector3 moveDirection = (targetPosition - transform.position).normalized;
        rb.velocity = moveDirection * moveSpeed;
    }
}