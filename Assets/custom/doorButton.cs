using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class doorButton : XRBaseInteractable
{
    public int motorDirection = -1;
    public HingeJoint motorJoint;


    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        motorDirection *= -1;
    }

    // Update is called once per frame
    void Update()
    {
        JointMotor jm = motorJoint.motor;
        jm.targetVelocity = Mathf.Abs(jm.targetVelocity) * motorDirection;
        motorJoint.motor = jm;
        gameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
    }

}
