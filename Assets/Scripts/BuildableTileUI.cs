using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildableTileUI : MonoBehaviour
{

    private BuildableTile target;
    //this is excessive, i should create a way to access all the towers from one script probably.
    private FlameTower flameTower;

    public GameObject ui;

    public Text towerNameText;
    public Text towerDescriptionText;
    public Text goldSellPriceText;
    public Text upgradeCostText;

    public void SetTarget (BuildableTile _target)
    {
        target = _target;

        transform.position = target.GetBuildPosition();
        ui.SetActive(true);
    }
    /*
    public void UpdateFlameTowerUI()
    {
        towerNameText.text = flameTower.getTowerName();
        
    }*/

    public void HideUI ()
    {
        ui.SetActive(false);
    }

}
