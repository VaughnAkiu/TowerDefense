
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BuildableTile : MonoBehaviour
{
    //public GameObject towerPrefab;
    [Header("Optional")]
    public GameObject tower;
    public TowerBlueprint towerBlueprint;
    //public Text errorText;
    private string notEnoughGoldString;

    TextMaster textMaster;
    BuildManager buildManager;

    
    private void Start()
    {
        buildManager = BuildManager.instance;
        textMaster = TextMaster.instance;
    }

    public Vector2 GetBuildPosition ()
    {
        return transform.position;
        //return transform.position + positionOffest;
    }


    //to implement, if trying to place on monster path or existing tower then return false, else return true
    private bool CanPlaceTower()
    {
      
        if (tower != null)
        {
            Debug.Log("turret already built");
            return false;
        }
        return true;
    }

    //activate when mouse click is finished
    private void OnMouseDown()
    {

        //if tower is built return this tile to the buildManager.
        if (tower != null)
        {
            buildManager.SelectNode(this);
            return;
        }

        if (!buildManager.CanBuild)
            return;

        BuildTower(buildManager.GetTowerToBuild());
    
        //play audio source
        //play visual effect
        //deduct gold
    }

    private void BuildTower (TowerBlueprint blueprint)
    {
        if (PlayerStats.gold < blueprint.cost)
        {
            Debug.Log("Not enough money to build this tower.");
            //send popup text (red floating text)
            notEnoughGoldString = "Not enough gold, you need " + blueprint.cost + " gold to build this tower.";
            textMaster.spawnText(notEnoughGoldString, transform.position);
            return;
        }

        //subtract tower cost from player gold
        PlayerStats.gold -= blueprint.cost;
        //update UI player gold text
        PlayerStats.instance.ChangeGoldText();
        //instantiate tower onto tile
        GameObject _tower = (GameObject)Instantiate(blueprint.prefab, GetBuildPosition(), Quaternion.identity);
        tower = _tower;

        towerBlueprint = blueprint;

        //play effect (instantiate effect at build spot)
        //destroy effect

        Debug.Log("Turret built!");
    }





}
