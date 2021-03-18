using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float cameraSpeed;
    public bool cameraInverted;

    public Transform verRot;
    public Transform horRot;

    float mouseMoveX;
    float mouseMoveY;
    Vector3 targetRotate;
    Vector3 targetLocalRotate;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        verRot = transform.parent;
        horRot = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        mouseMoveX = Input.GetAxis("Mouse X") * cameraSpeed;
        mouseMoveY = Input.GetAxis("Mouse Y") * cameraSpeed;

        /*if (mouseMoveX != 0) {
            Debug.Log($"X:{mouseMoveX}, Y:{mouseMoveY}");
        }*/

        if (cameraInverted) {
            verRot.transform.Rotate(0,-mouseMoveX,0);
            horRot.transform.Rotate(mouseMoveY,0,0);
        } else {
            verRot.transform.Rotate(0,mouseMoveX,0);
            horRot.transform.Rotate(-mouseMoveY,0,0);
        }
    }
}
