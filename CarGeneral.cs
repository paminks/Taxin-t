using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarGeneral : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 200f;
    private CarGeneral cg;
    private Rigidbody2D rb;
    public bool isActive =false;
    private PlayerScripts ps;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ps = GetComponent<PlayerScripts>();
    }

    public void Update()
    {
        
        if (isActive) 
        {
            Controls();
        }
    }

    private void Controls()
    {
        float moveInput = Input.GetAxis("Vertical");
        float rotateInput = Input.GetAxis("Horizontal");

        // Move the car forward/backward
        rb.velocity = transform.up * moveInput * speed;

        // Rotate the car left/right
        rb.angularVelocity = -rotateInput * rotationSpeed;
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        isActive = true;
    }
}
