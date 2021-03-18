using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpPower;

    Rigidbody rb;
    float moveX = 0f;
    float moveZ = 0f;
    bool jump;

    bool isOnFloor;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        jump = Input.GetButtonDown("Jump");
        if (jump) {
            rb.AddForce(transform.up * jumpPower, ForceMode.Impulse);
        }
    }

    void FixedUpdate(){
        moveX = Input.GetAxis ("Horizontal") * speed;
        moveZ = Input.GetAxis ("Vertical") * speed;

        // Debug.Log($"X:{moveX}, Z:{moveZ}"); // デバッグ用移動量取得
        if (moveX == 0 && moveZ == 0) {
            rb.velocity = new Vector3(0, rb.velocity.y, 0);
        } else if (rb.velocity.magnitude < 5) {
            rb.AddForce(transform.forward * moveX);
            rb.AddForce(-transform.right * moveZ);
        }
        // rb.velocity = new Vector3(moveX, rb.velocity.y, moveZ); // velocityを直接書き換えるタイプ
    }
}
