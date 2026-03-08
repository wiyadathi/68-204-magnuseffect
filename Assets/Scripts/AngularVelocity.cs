using UnityEngine;
using UnityEngine.InputSystem; // New Input System

public class AngularVelocity : MonoBehaviour
{
    public float angularSpeed; // speed for Angular Velocity

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Press 'A' to Rotate using Angular Velocity
        if (Keyboard.current.aKey.isPressed)
        {
            rb.angularVelocity = new Vector3(0, angularSpeed, 0);
        }

      // Stop rotation
        else
        {
            rb.angularVelocity = Vector3.zero;
        }
    }
}
