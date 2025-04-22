using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTriggers : MonoBehaviour
{
    public GameObject goldfish;
    public GameObject dogBowl;

    private int goldfishInt = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(goldfish != null)
        {


        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(goldfish != null && goldfishInt < 1)
        {
            Debug.Log("GoldFish in dogbowl");
            goldfishInt++;
        }
       
    }
}
