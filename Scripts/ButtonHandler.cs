using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    /// <summary>
    /// updated to an abstract for the base class of plant. So that it will be easier to expand the program. 
    /// </summary>
    BunnySucculent script;
    public GameObject plant;
    public void Start()
    {
        script = plant.GetComponent<BunnySucculent>();
    }

    public void waterPlant()
    {
       script.waterReserve = 100.0f;
    }
    public void fertilizePlant()
    {
        script.fertilizerReserve = 100.0f;
    }
}
