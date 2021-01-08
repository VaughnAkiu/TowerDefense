
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

    private GameObject turretToBuild;
    /*
    private void Start()
    {
        turretToBuild = FlameTower;
    }*/


    public void BuildFlameTower()
    {
        turretToBuild = FlameTower;
        selectedTile = null;
        buildableTileUI.HideUI();
    }
    public void BuildFrostTower()
    {
        turretToBuild = FrostTower;
        selectedTile = null;
        buildableTileUI.HideUI();
    }
    public void BuildLightningTower()
    {
        turretToBuild = LightningTower;
        selectedTile = null;
        buildableTileUI.HideUI();

    }

    public void SelectTurretToBuild(TowerBlueprint tower)
    {
        towerToBuild = tower;
        //DeselectBuildableTile();
    }


    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SelectNode(BuildableTile node)
    {
        if (selectedTile == node)
        {
            DeselectNode();
            return;
        }

        turretToBuild = null;
        selectedTile = node;
        buildableTileUI.SetTarget(node);
        //going to have to change this.
        buildableTileUI.UpdateFlameTowerUI();
    }

    public void DeselectNode()
    {
        selectedTile = null;
        buildableTileUI.HideUI();
    }


}
