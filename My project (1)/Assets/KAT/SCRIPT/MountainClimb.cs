using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MountainClimb : MonoBehaviour
{
    public float climbSpeed = 3f;
    public float maxClimbAngle = 60f; // Maximum slope angle the player can climb
    private Rigidbody rb;
    private bool isClimbing = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (isClimbing)
        {
            Climb();
        }
    }

    void OnCollisionStay(Collision collision)
    {
        // Check if the collided object is climbable and steep enough
        if (collision.gameObject.CompareTag("Climbable"))
        {
            foreach (ContactPoint contact in collision.contacts)
            {
                float angle = Vector3.Angle(contact.normal, Vector3.up);
                if (angle > 45f && angle <= maxClimbAngle)
                {
                    isClimbing = true;
                    rb.useGravity = false;
                    return;
                }
            }
        }
        isClimbing = false;
        rb.useGravity = true;
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Climbable"))
        {
            isClimbing = false;
            rb.useGravity = true;
        }
    }

    void Climb()
    {
        float vertical = Input.GetAxis("Vertical");
        Vector3 climbDirection = new Vector3(0, vertical, 0);
        rb.velocity = new Vector3(rb.velocity.x, climbDirection.y * climbSpeed, rb.velocity.z);
    }
}
