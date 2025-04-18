using JetBrains.Annotations;
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
    ObjectInteration objectInt;
   

    private void Start()
    {
        objectInt = GameObject.FindGameObjectWithTag("Player").GetComponent<ObjectInteration>();
        rb = GetComponent<Rigidbody>();
    }
    public void PickingUpObjects()
    {
        //Debug.Log("Script Read ");
        
        if (objectInt.interactable == true)
        {
            //Debug.Log("Interactable is true");
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("E clicked");
                objTransform.parent = cameraTrans;
                rb.useGravity = false;
                pickedUp = true;

                Debug.Log("pick");

            }
            if (Input.GetMouseButtonUp(0))
            {
                objTransform.parent = null;
                rb.useGravity = true;
                pickedUp = false;

            }
            //throwing mechanic? couldn't get the object to move on the X/Z and not the Y
            /*if (pickedUp == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    objTransform.transform.parent = null;
                    rb.useGravity = false;
                    rb.velocity = cameraTrans.forward * throwAmount * Time.deltaTime;
                    pickedUp = false;

                }

            }*/

        }
        
    }

}
