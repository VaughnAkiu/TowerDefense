using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    
    //use static so can be accessed by other scripts
    //giving values to static variables means the variable will reset to this value on scene change
    public static int gold = 100;
    public static int mobKills = 0;
    public static int livesRemaining = 1;
    public static int waveLevel;
    public static int jewels = 0; //currency that can be used outside of the maps to buy 'special' stuff

    //Unity stuff
    public Text killCountText;
    public Text playerLivesText;
    public Text waveLevelText;
    public Text playerGoldText;

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
        playerGoldText.text = "Gold: " + PlayerStats.gold;
        //waveLevelText.text = "Wave Level: " + PlayerStats.waveLevel;
    }


    public void ChangeKillCountText()
    {
        killCountText.text = "Kill Count: " + PlayerStats.mobKills;
        //killCountText.GetComponent<Text>().text = "Kill Count " + PlayerStats.mobKills;
    }
    
    public void ChangePlayerLivesText()
    {
        playerLivesText.text = "Lives: " + PlayerStats.livesRemaining;
    }

    public void ChangeWaveLevelText()
    {
        waveLevelText.text = "Wave Level: " + PlayerStats.waveLevel;
    }

    public void ChangeGoldText()
    {
        playerGoldText.text = "Gold: " + PlayerStats.gold;
    }
}
