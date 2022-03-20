using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ElevatorButton : XRBaseInteractable
{
    public int floor = 1;
    public CharacterController cc;
    public List<Vector3> floorPositions = new List<Vector3>() { 
        new Vector3(0,0,-3.75f),
        new Vector3(0,3.6f,-3.75f),
        new Vector3(0,12.2f,-3.75f),
    };

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        MovePlayer(floor);
    }


    private void MovePlayer(int i)
    {
        cc.enabled = false;
        cc.transform.position = floorPositions[i];
        cc.enabled = true;
    }

}
