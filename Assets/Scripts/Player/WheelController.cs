using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{

    public GameObject[] wheelsToRotate;
    public TrailRenderer[] trails;
    public float rotaionSpeed;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float verticalAxis = Input.GetAxisRaw("Vertical");
        float horizontalAxis = Input.GetAxisRaw("Horizontal");

        foreach (var wheel in wheelsToRotate)
        {
            wheel.transform.Rotate(Time.deltaTime * -verticalAxis * rotaionSpeed, 0, 0, Space.Self);
        }

        if(horizontalAxis > 0)
        {
            anim.SetBool("goingLeft", false);
            anim.SetBool("goingRight", true);
        }
        else if(horizontalAxis < 0)
        {
            anim.SetBool("goingRight", false);
            anim.SetBool("goingLeft", true);            
        }
        else
        {
            anim.SetBool("goingRight", false);
            anim.SetBool("goingLeft", false);              
        }

        if(horizontalAxis != 0)
        {
            foreach (var trail in trails)
            {
                trail.emitting = true;
            }
        }
        else
        {
            foreach (var trail in trails)
            {
                trail.emitting = false;
            }
        }
    }
}
