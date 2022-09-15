using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonControl : MonoBehaviour
{
    public float controlHor;
    public float controlVert;

    float rotationHor = 40;
    float rotationVert = 40;

    public float speedHor = 1;
    public float speedVer = 1;

    public int wheelRotationSpeed;
    public Animator humanAnimator;

    Transform cannon;
    Transform wheelR;
    Transform wheelL;
    void Start()
    {
        cannon = transform.GetChild(1);
        wheelR = transform.GetChild(2);
        wheelL = transform.GetChild(3);
    }

    void Update()
    {
        Control();
        
    }

    public void Control()
    {
        rotationHor = Input.GetAxis("Horizontal") * Time.deltaTime;
        rotationVert = Input.GetAxis("Vertical") * Time.deltaTime;

        controlHor = Mathf.Clamp(controlHor + rotationHor * speedHor, -30, 30);
        controlVert = Mathf.Clamp(controlVert + rotationVert * speedVer, -10, 30);

        float timeSpeedfactor = Time.deltaTime * wheelRotationSpeed;
        if (rotationHor > 0 && controlHor < 30)
        {
            humanAnimator.SetBool("Push", true);
            wheelR.Rotate(Vector3.back * timeSpeedfactor);
            wheelL.Rotate(Vector3.forward * timeSpeedfactor);
        }
        else if (rotationHor < 0 && controlHor > -30)
        {
            humanAnimator.SetBool("Pull", true);
            wheelR.Rotate(Vector3.forward * timeSpeedfactor);
            wheelL.Rotate(Vector3.back * timeSpeedfactor);
        }
        else
        {
            humanAnimator.SetBool("Pull", false);
            humanAnimator.SetBool("Push", false);
        }
        
        transform.rotation = Quaternion.Euler(0 , controlHor, 0);
        cannon.localRotation = Quaternion.Euler(controlVert, 0 , 0);
    }
}
