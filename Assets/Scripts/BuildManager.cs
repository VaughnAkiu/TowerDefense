
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
    public GameObject standardTurretPrefab;
    public GameObject turret2;

    private GameObject turretToBuild;

    private void Start()
    {
        turretToBuild = standardTurretPrefab;
    }

    

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }


}
