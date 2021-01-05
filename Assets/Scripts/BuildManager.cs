
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    //singleton pattern
    //one instance of build manager referencing itself
    public static BuildManager instance;


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
    }

    public void BuildFrostTower()
    {
        turretToBuild = FrostTower;
    }

    public void BuildLightningTower()
    {
        turretToBuild = LightningTower;
    }

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }


}
