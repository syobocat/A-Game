using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour
{
    private bool isOnFloor = true;

    public bool IsOnFloor() {
        return isOnFloor;
    }

    private void OnTriggerEnter(Collider collision)
    {
        isOnFloor = true;
    }

    private void OnTriggerExit(Collider collision)
    {
        isOnFloor = false;
    }
}
