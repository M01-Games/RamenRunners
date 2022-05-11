using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController_RR : MonoBehaviour
{
    private float moveInput;
    private float turnInput;
    private bool isCarGrounded;

    public float airDrag;
    public float groundDrag;
    public float fwdSpeed;
    public float revSpeed;
    public float turnSpeed;
    public LayerMask groundLayer;
    
    public Rigidbody sphereRB;
    public Rigidbody carRB;
    
    
        // Start is called before the first frame update
    void Start()
    {
        sphereRB.transform.parent = null;
        carRB.transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxisRaw("Vertical");
        turnInput = Input.GetAxisRaw("Horizontal");
        moveInput *= fwdSpeed;
        if(moveInput > 0)
        {
            moveInput *= fwdSpeed;
        }
        else
        {
            moveInput *= revSpeed;
        }

        transform.position = sphereRB.transform.position;
        float newRotaion = turnInput * turnSpeed * Time.deltaTime * Input.GetAxisRaw("Vertical");
        transform.Rotate(0 , newRotaion, 0, Space.World);

        RaycastHit hit;
        isCarGrounded = Physics.Raycast(transform.position, -transform.up, out hit, 1f, groundLayer);
        transform.rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;

        if(isCarGrounded)
        {
            sphereRB.drag = groundDrag;
        }
        else
        {
            sphereRB.drag = airDrag;
        }
    }

    private void FixedUpdate() 
    {
        if(isCarGrounded)
        {
            sphereRB.AddForce(transform.forward * moveInput, ForceMode.Acceleration);
        }
        else
        {
            sphereRB.AddForce(transform.up * -30f);
        }

        carRB.MoveRotation(transform.rotation);
    }
}
