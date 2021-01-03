
using UnityEngine;

public class PlaceTower : MonoBehaviour
{
    //public GameObject towerPrefab;
    private GameObject tower;

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
        if (CanPlaceTower())
        {
            GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
            tower = (GameObject)Instantiate(turretToBuild, transform.position, transform.rotation);
        }


        //play audio source
        //play visual effect
        //deduct gold
    }





}
