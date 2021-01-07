using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildableTileUI : MonoBehaviour
{

    private BuildableTile target;

    public GameObject ui;

    public void SetTarget (BuildableTile _target)
    {
        target = _target;

        transform.position = target.GetBuildPosition();
        ui.SetActive(true);
    }

    public void HideUI ()
    {
        ui.SetActive(false);
    }

}
