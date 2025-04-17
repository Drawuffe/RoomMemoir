using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private GameObject player;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);

        }
        else
        {
            Destroy(gameObject);
        }

      

    }


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            ResetGame();

        }
    }

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
