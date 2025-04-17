using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickingUp : MonoBehaviour
{
    public GameObject crosshair1, crosshair2;
    public Transform objTransform, cameraTrans;
    public bool pickedUp;
    private Rigidbody rb;
    public float throwAmount;

    
    public bool interactable;

    private void Start()
    {
       
        rb = GetComponent<Rigidbody>();
    }
    public void PickingUpObjects()
    {
        if (interactable == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                objTransform.parent = cameraTrans;
                rb.useGravity = false;
                pickedUp = true;

            }
            if (Input.GetMouseButtonUp(0))
            {
                objTransform.parent = null;
                rb.useGravity = true;
                pickedUp = false;

            }
            if (pickedUp == true)
            {
                if (Input.GetMouseButtonDown(1))
                {
                    objTransform.transform.parent = null;
                    rb.useGravity = true;
                    rb.velocity = cameraTrans.forward * throwAmount * Time.deltaTime;
                    pickedUp = false;

                }

            }


        }
    }

}
