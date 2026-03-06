using UnityEngine;
using UnityEngine.InputSystem; // New Input System

public class AngularVelocity : MonoBehaviour
{
    public float rotateSpeed = 5f;   // rotation speed
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // When pressing "A"
        if (Keyboard.current.aKey.isPressed)
        {
            // Rotate around Y axis using Angular Velocity
            rb.angularVelocity = new Vector3(0, rotateSpeed, 0);
        }
/*        else if (Keyboard.current.sKey.isPressed)
        {
            // Stop rotating when key "s" is pressed
            rb.angularVelocity = Vector3.zero;
        }*/
        else 
        {
            //Stop rotating when no key is pressed
            rb.angularVelocity = Vector3.zero;
        }
    }
}
