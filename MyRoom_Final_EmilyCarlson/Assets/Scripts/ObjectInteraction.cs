using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ObjectInteration : MonoBehaviour
{
    [SerializeField]
    private LayerMask pickableLayerMask;

    [SerializeField]
    private Transform playerCameraTransform;

    [SerializeField]
    private GameObject pickUpUI;

    [SerializeField]
    [Min(1)]
    private float hitRange = 3;

    private RaycastHit hit;

    public bool interactable;
    
    PickingUp pickingUp;
    private void Start()
    {
        pickingUp = GetComponent<PickingUp>();
    }
    private void Update()
    {

        Debug.DrawRay(playerCameraTransform.position, playerCameraTransform.forward * hitRange, Color.red);
        if (hit.collider != null)
        {
            hit.collider.GetComponent<Highlight>()?.ToggleHighlight(false);
            pickUpUI.SetActive(false);
            
           
        }

        if (Physics.Raycast(playerCameraTransform.position,playerCameraTransform.forward,out hit,hitRange,pickableLayerMask))
        {
            hit.collider.GetComponent<Highlight>()?.ToggleHighlight(true);
            pickUpUI.SetActive(true);
            pickingUp.PickingUpObjects();
            Debug.Log("Interactable is true");
           
        }

     
    }

}
