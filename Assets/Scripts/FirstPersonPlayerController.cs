using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FirstPersonPlayerController : MonoBehaviour
{


    public float speed = 8;
    public float jumpSpeed = 4;
    public float gravity = -9.8f;

    private Vector3 velocity;
    private CharacterController characterController;
    private Vector3 upVector = new Vector3(0, 1, 0);

    // Start is called before the first frame update
    void Start()
    {
        velocity = new Vector3(0, 0, 0);
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = GetForwardVector();
        Vector3 right = Vector3.Cross(Vector3.up, forward).normalized; // Unity's coordinate system is left-handed... Weird.
        Vector3 horizontalPlaneVelocity = speed * (Input.GetAxis("Horizontal") * right + Input.GetAxis("Vertical") * forward);
        velocity.x = horizontalPlaneVelocity.x;
        velocity.z = horizontalPlaneVelocity.z;

        if (characterController.isGrounded)
        {
            velocity.y = Input.GetAxis("Jump") * jumpSpeed;
            if (velocity.y < 0) velocity.y = 0;
        }
        else
        {
            velocity.y += gravity * Time.deltaTime;
        }


        characterController.Move(velocity * Time.deltaTime);
    }

    private Vector3 GetForwardVector()
    {
        Vector3 camForward = Camera.main.transform.forward;
        return new Vector3(camForward.x, 0, camForward.z).normalized;
    }
}
