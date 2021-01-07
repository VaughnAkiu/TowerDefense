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
    public Text goldCostText;
    public Text upgradeCostText;

    public void SetTarget (BuildableTile _target)
    {
        target = _target;

        transform.position = target.GetBuildPosition();
        ui.SetActive(true);
    }


    public void HideUI ()
    {
        ui.SetActive(false);
    }

}
