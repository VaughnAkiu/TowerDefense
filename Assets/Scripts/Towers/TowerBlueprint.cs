using System.Collections;
using UnityEngine;

//need to mark this as serializable to see it in the editor
[System.Serializable]
public class TowerBlueprint
{
    public GameObject prefab;
    public int cost;
    public string towerDescription;
    public string towerName;
    public int upgradeCost;



}
