using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectTriggers : MonoBehaviour
{
    public GameObject goldfish;
    

    private int goldfishInt = 0;

    [SerializeField]
    private GameObject goldFishImage;

    // Start is called before the first frame update
    void Start()
    {
      
        goldFishImage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(goldfishInt == 1)
        {


        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(goldfishInt <= 0)
        {
            Debug.Log("GoldFish in dogbowl");
            goldfishInt++;
        }
        if(goldfishInt >= 1)
        {
            goldfishInt = 1;
            goldFishImage.SetActive(true);

        }
       
    }
}
