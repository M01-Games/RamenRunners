using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController_RR : MonoBehaviour
{
        #region Variable
        //Variables (pulic can be changed in unity / private can ONLY be changed in script)
    public GameObject[] wheelsToRotate; //An array of the wheels that are on the car
    public TrailRenderer[] trails; //An array of the trailrenderers for the skid marks
    public float rotaionSpeed; //The speed the wheels will rotate at
    private Animator anim; //The animations for the wheels
        #endregion

        #region Methods
    void Start() //Runs at the first frame
    {
        anim = GetComponent<Animator>();
    }
    void Update() //Runs every frame
    {
        float verticalAxis = Input.GetAxisRaw("Vertical"); //This takes the X axis input
        float horizontalAxis = Input.GetAxisRaw("Horizontal"); //This takes the Y axis input

        foreach (var wheel in wheelsToRotate) //This makes all the wheels within the array do...
        {
            wheel.transform.Rotate(Time.deltaTime * -verticalAxis * rotaionSpeed, 0, 0, Space.Self); //Rotates the wheels 
        }
        if(horizontalAxis > 0) //Checks if the Y input is greater than 0 if so...
        {
            anim.SetBool("goingLeft", false); //Turns the going left animation off
            anim.SetBool("goingRight", true); //Turns the going right animation on
        }
        else if(horizontalAxis < 0) //Checks if the Y input is less than 0 if so...
        {
            anim.SetBool("goingRight", false); //Turns the going right animation off
            anim.SetBool("goingLeft", true); //Turns the going left animation on
        }
        else //If not...
        {
            anim.SetBool("goingRight", false); //Turns the going right animation off
            anim.SetBool("goingLeft", false); //Turns the going left animation off
        }
        if(horizontalAxis != 0) //Checks if the Y input is NOT equal to 0 if so...
        {
            foreach (var trail in trails) //This makes all the trailrenderers within the array do...
            {
                trail.emitting = true; //Turns on the trails
            }
        }
        else //If not...
        {
            foreach (var trail in trails) //This makes all the trailrenderers within the array do...
            {
                trail.emitting = false; //Turns off the trails
            }
        }
    }
        #endregion
}