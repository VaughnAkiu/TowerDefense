
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    //singleton pattern
    //one instance of build manager referencing itself
    public static BuildManager instance;

    //implementing this to try and understand it better.
    private BuildableTile selectedTile;

    public BuildableTileUI buildableTileUI;


    private TowerBlueprint towerToBuild;
    //(property) only allowed to get something, variable can never be set
    //check if turretToBuild != null then return the result (turretToBuild)
    public bool CanBuild { get { return towerToBuild != null; } }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BuildManager in scene");
            return;
        }
        instance = this;
    }

    //turrets
    public GameObject FlameTower;
    public GameObject FrostTower;
    public GameObject LightningTower;


    public void SelectTowerToBuild(TowerBlueprint tower)
    {
        towerToBuild = tower;
        //DeselectBuildableTile();
    }

    public TowerBlueprint GetTowerToBuild()
    {
        return towerToBuild;
    }

    /*
    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }*/

    public void SelectNode(BuildableTile givenTile)
    {
        //if selectedTile is equal to givenTile then deselect the tile and hide the UI
        //if tile is already selected then deselect and hide UI
        if (selectedTile == givenTile)
        {
            DeselectNode();
            return;
        }

        //get rid of turret on cursor?
        towerToBuild = null;
        selectedTile = givenTile;
        //can put in selected tile or given tile since it was just assigned
        //set target transforms UI to that position and sets the UI active
        buildableTileUI.SetTarget(givenTile);
        //going to have to change this.
        //buildableTileUI.UpdateFlameTowerUI();
    }

    public void DeselectNode()
    {
        selectedTile = null;
        buildableTileUI.HideUI();
    }


}
