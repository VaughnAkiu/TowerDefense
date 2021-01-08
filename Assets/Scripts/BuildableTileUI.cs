using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildableTileUI : MonoBehaviour
{

    private BuildableTile target;

    public GameObject ui;

    public Text towerNameText;
    public Text towerDescriptionText;
    public Text goldSellPriceText;
    public Text upgradeCostText;

    /// <summary>
    /// transforms UI to according buildable tile and sets the UI active at that position
    /// </summary>
    /// <param name="_target"></param>
    public void SetTarget (BuildableTile _target)
    {
        target = _target;
        transform.position = target.GetBuildPosition();
        UpdateUI();
        ui.SetActive(true);
    }
    
    public void UpdateUI()
    {
        towerNameText.text = target.towerBlueprint.towerName;
        towerDescriptionText.text = target.towerBlueprint.towerDescription;
        
        
    }

    public void HideUI ()
    {
        ui.SetActive(false);
    }

}
