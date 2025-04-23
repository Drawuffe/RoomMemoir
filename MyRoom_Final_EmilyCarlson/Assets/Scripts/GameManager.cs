using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private GameObject player;

    //[SerializeField]
    //private GameObject bookMenu;

    public bool bookMenuOpen;
   
    private void Awake()
    {


    }


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
 
        //bookMenu.SetActive(false);
        bookMenuOpen = false;
   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            ResetGame();

        }

        
        
           
        //set up book mechanic here

        

     
    }

    /*private void CloseBook()
    {
        bookMenu.SetActive(false);
        bookMenuOpen = false;
        Debug.Log("Book closed");


    }
    private void OpenBook()
    {
        bookMenu.SetActive(true);
        bookMenuOpen = true;
        Debug.Log("Book opened"); */


    public void ResetGame()
    {
        //Reset the images of the found item/interactions
        //set all the bools false for the interactions
        //put player at starting spot
        //SceneManager.Loadscene(sceneManager.getActiveScene () . buildIndex);

    }
}
//Could add player respawn here/ ways player may die(dont think that will be needed for this game)
//Set up interaction display here
//Scoring/health
