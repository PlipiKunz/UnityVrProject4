using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabbable : MonoBehaviour
{
    public bool grabbed = false;
    public void grabToggle() {
        grabbed = !grabbed;
        if (grabbed) gameObject.layer = 6;
        else Invoke(setNormal(), 1);
    }

    private string setNormal() {
        gameObject.layer = 0;
        return "";
    }

}
