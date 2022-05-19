using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController_RR : MonoBehaviour
{
        #region Variable
        //Variables (pulic can be changed in unity / private can ONLY be changed in script)
    private float moveInput; //The input value for the players movement
    private float turnInput; //The input value for the players turning
    private bool isCarGrounded; //A yes or no if the player is on the ground
    public float airDrag; //The drag value for when the players car is in the air
    public float groundDrag; //The drag value for when the players car is on the ground
    public float fwdSpeed; //The forward speed value for when the player goes forward
    public float revSpeed; //The reverse speed value for the when the player goes backwards
    public float turnSpeed; //The turn speed of the players car
    public LayerMask groundLayer; //The ground layer of the level
    public Rigidbody sphereRB; //The car motors rigidbody
    public Rigidbody carRB; //The car colliders rigidbody
        #endregion

        #region Methods
    void Start() //Runs at the first frame
    {
        sphereRB.transform.parent = null; //Removes the rigidbody from the main car but leaves it connected via scripts to allow for minimun collisons between the model and the motor
        carRB.transform.parent = null; //Removes the rigidbody from the main car but leaves it connected via scripts to allow for minimun collisons between the model and the motor
    }
    void Update() //Runs every frame
    {
        moveInput = Input.GetAxisRaw("Vertical"); //Sets the Movement input value to the value of the games inputs
        turnInput = Input.GetAxisRaw("Horizontal"); //Sets the Turning input value to the value of the games inputs
        moveInput *= fwdSpeed; //Sets the movement input to the combined value of both the forward speed and the input values
        if(moveInput > 0) //Checks if the input is greater than 0 if so...
        {
            moveInput *= fwdSpeed; //Sets the movement speed to the forward speed
        }
        else //If not...
        {
            moveInput *= revSpeed; //Sets the movemnt speed to the reverse speed
        }

        transform.position = sphereRB.transform.position; //Sets this gameobjects position to the position of the motor
        float newRotaion = turnInput * turnSpeed * Time.deltaTime * Input.GetAxisRaw("Vertical"); //Creates a new rotation by cominding all the turning values
        transform.Rotate(0 , newRotaion, 0, Space.World); //Sets this obejct to the new rotation

        RaycastHit hit; //Creates a store of objects the raycast hits
        isCarGrounded = Physics.Raycast(transform.position, -transform.up, out hit, 1f, groundLayer); //Creates a raycast pointing down from the player and sets it to the yes or no value
        transform.rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation; //Sets this gameobjects Y rotation to the Y rotation of the ground 

        if(isCarGrounded) //Checks if the car is on the ground if so...
        {
            sphereRB.drag = groundDrag; //Sets the motor drag to the ground drag value
        }
        else //If not
        {
            sphereRB.drag = airDrag; //Sets the motor drag to the air drag value
        }
    }
    private void FixedUpdate() //Runs every frame but limits it self to 60
    {
        if(isCarGrounded) //Checks if the car is on the ground if so...
        {
            sphereRB.AddForce(transform.forward * moveInput, ForceMode.Acceleration); //Applys a force to the motor which is equivelent to the movement input
        }
        else //If not...
        {
            sphereRB.AddForce(transform.up * -30f); //Applys a downwards force to bring the motor back to the grounf layer
        }
        carRB.MoveRotation(transform.rotation); //Sets the rotaion of the car to this gameobjects rotation
    }
        #endregion
}