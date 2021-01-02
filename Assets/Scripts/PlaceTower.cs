
using UnityEngine;

public class PlaceTower : MonoBehaviour
{
    public GameObject towerPrefab;
    private GameObject tower;

    //to implement, if trying to place on monster path or existing tower then return false, else return true
    private bool CanPlaceTower()
    {
        return true;
    }

    //activate when mouse click is finished
    private void OnMouseUp()
    {
        if (CanPlaceTower())
        {
            tower = (GameObject)Instantiate(towerPrefab, transform.position, Quaternion.identity);
        }
        //play audio source
        //play visual effect
        //deduct gold
    }





}
