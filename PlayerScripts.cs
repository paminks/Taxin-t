using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScripts : MonoBehaviour
{

    public float playerSpeed;
    private Rigidbody2D rb;
    public GameObject player;
    private CarGeneral cg;
    public Transform carTransform;
    public CinemachineVirtualCamera cam;
    public GameObject cars;
    public Transform carsT;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cg = GetComponent<CarGeneral>();
        cars = GameObject.FindGameObjectWithTag("Car");
        carsT = cars.GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        

        cars = GameObject.FindGameObjectWithTag("Car");
        carsT = cars.GetComponent<Transform>();

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb.velocity = movement * playerSpeed;
        if(player)
        {
            cam.Follow = player.transform;
        }

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Car"))
        {
            player.SetActive(false);
            cam.Follow = carsT;
            
        }
    }
}
