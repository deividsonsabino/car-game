using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //[SerializeField] private float speed = 20.0f;
    [SerializeField] private float horsePower = 0;
    private const float turnSpeed = 25.0f;
    private float horizontalInput;
    private float vertialInput;
    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        vertialInput = Input.GetAxis("Vertical");
        playerRb.AddRelativeForce(Vector3.forward * horsePower * vertialInput);
        // We move the vehicle forward
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * vertialInput);
        // We turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
