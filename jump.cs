using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public float jumpSpeed = 5;
    private Rigidbody rb;
    private bool onground = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && onground)
        {
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            onground = false;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        onground = true;
    }
}
