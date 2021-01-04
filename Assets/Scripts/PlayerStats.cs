using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    
    //use static so can be accessed by other scripts
    public static int gold;
    public static int mobKills = 0;
    public static int livesRemaining = 100;

    //Unity stuff
    public Text killCountText;
    public Text playerLivesText;

    //singleton pattern
    //one instance of PlayerStats referencing itself
    public static PlayerStats instance;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one PlayerStats in scene");
            return;
        }
        instance = this;

        //possibly load in save file here
    }

    private void Start()
    {
        killCountText.text = "Kill Count: " + PlayerStats.mobKills;
        playerLivesText.text = "Lives: " + PlayerStats.livesRemaining;
    }


    public void ChangeKillCountText()
    {
        killCountText.text = "Kill Count: " + PlayerStats.mobKills;
        //killCountText.GetComponent<Text>().text = "Kill Count " + PlayerStats.mobKills;
    }
    
    public void ChangePlayerLives()
    {
        playerLivesText.text = "Lives: " + PlayerStats.livesRemaining;
    }
}