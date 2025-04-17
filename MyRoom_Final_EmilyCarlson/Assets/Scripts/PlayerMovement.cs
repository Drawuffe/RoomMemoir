using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody rb;
    public float walkSpeed = 10f;
    public float mouseSens;
    public Transform cameraTrans;
    private float yRotation = 0, xRotation = 0;
    public bool isCrouching = false;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    private void Update()
    { 
        float horizontalInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        rb.velocity = transform.forward * zInput * walkSpeed +
            transform.right * horizontalInput * walkSpeed + Vector3.up * rb.velocity.y;

        CameraLook();

        if (Input.GetKeyDown(KeyCode.Q))
        {
            isCrouching = !isCrouching;
            Crouch();

        }

        //mechanics to see the distance from objects here?

    
    }

    private void CameraLook()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        yRotation += mouseX;
        transform.rotation = Quaternion.Euler(0f, yRotation, 0);

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        cameraTrans.localRotation = Quaternion.Euler(xRotation, 0, 0);
    }

    private void Crouch()
    {
        if(isCrouching)
        {
            transform.localScale = new Vector3(45,25,45);

        }
        else
        {
            transform.localScale = new Vector3(45,45,45);

        }

    }
}



