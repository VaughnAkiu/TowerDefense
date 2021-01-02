
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    //one instance of build manager referencing itself
    public static BuildManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BuildManager in scene");
        }
        instance = this;
    }

    //turrets
    public GameObject standardTurretPrefab;
    public GameObject turret2;

    private void Start()
    {
        turretToBuild = standardTurretPrefab;
    }


    private GameObject turretToBuild;


    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }


}
