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
        buildManager.SelectTowerToBuild(flameTower);
    }
    public void SelectIceTower()
    {
        Debug.Log("Ice Tower selected.");
        buildManager.SelectTowerToBuild(iceTower);
    }
    public void SelectLightningTower()
    {
        Debug.Log("Lightning Tower selected.");
        buildManager.SelectTowerToBuild(lightningTower);
    }
}
