
using UnityEngine;

public class PlaceTower : MonoBehaviour
{
    //public GameObject towerPrefab;
    private GameObject tower;

    //to implement, if trying to place on monster path or existing tower then return false, else return true
    private bool CanPlaceTower()
    {
        return true;
    }

    //activate when mouse click is finished
    private void OnMouseDown()
    {
        /*
        if (CanPlaceTower())
        {
            tower = (GameObject)Instantiate(towerPrefab, transform.position, Quaternion.identity);
        }*/
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        tower = (GameObject)Instantiate(turretToBuild, transform.position, transform.rotation);
        //play audio source
        //play visual effect
        //deduct gold
    }





}
