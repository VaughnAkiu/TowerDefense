using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    public TowerBlueprint flameTower;
    public TowerBlueprint iceTower;
    public TowerBlueprint lightningTower;

    BuildManager buildManager;

    // Start is called before the first frame update
    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectFlameTower()
    {
        Debug.Log("Flame Tower selected.");
        buildManager.SelectTurretToBuild(flameTower);
    }
    public void SelectIceTower()
    {
        Debug.Log("Ice Tower selected.");
        buildManager.SelectTurretToBuild(iceTower);
    }
    public void SelectLightningTower()
    {
        Debug.Log("Lightning Tower selected.");
        buildManager.SelectTurretToBuild(lightningTower);
    }
}
