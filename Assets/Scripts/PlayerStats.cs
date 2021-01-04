using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    
    //use static so can be accessed by other scripts
    public static int gold;
    public static int mobKills = 0;
    public static int livesRemaining;

    //Unity stuff
    public Text killCountText;


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
    }


    public void ChangeKillCountText()
    {
        killCountText.text = "Kill Count: " + PlayerStats.mobKills;
        //killCountText.GetComponent<Text>().text = "Kill Count " + PlayerStats.mobKills;
    }
    
}
