using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string name;
    public string description;
    //possibly used to increase tower damage
    public int damage = 0;
    //possibly used to increase tower attacking speed
    public int speed = 0;
    

    public string getName()
    {
        return this.name;
    }

    public string getDescription()
    {
        return this.description;
    }
    
    //placeholder
    //cloak of flame
    //
    
    
}
