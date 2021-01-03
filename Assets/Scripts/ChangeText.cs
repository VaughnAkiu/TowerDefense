using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    public GameObject killCountText;
    //public Text playerLivesText;


    public void ChangeKillCountText()
    {
        //killCountText.text = "Kill Count " + PlayerStats.mobKills;
        killCountText.GetComponent<Text>().text = "Kill Count " + PlayerStats.mobKills;
    }

    public void changePlayerLivesText()
    {

    }


}
