using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[System.Serializable]
public abstract class PlantAbstractTest : MonoBehaviour
{

    //variables needed for plant
    public float waterUsageValue;
    public float waterReserve;
    public float fertilizerNeed;
    public float fertilizerReserve;
    public float timeTillGermination;
    public float timeTillMaturity;
    public string scientificName;
    public string commonName;

    //time keeping variables;
    public float savedtime;
    //bools used to make sure that plant growth only happens once
    public bool oneRunGermination;
    public bool oneRunMaturity;

 
    //used to determine the age and size of the plant
    public void plantGrowth()
    {


        if (savedtime >= timeTillGermination && oneRunGermination == false)
        {
            oneRunGermination = true;
            this.transform.localScale += new Vector3(20.0f, 20.0f, 20.0f);
        }
        else if (savedtime >= timeTillMaturity && oneRunMaturity == false)
        {
            oneRunMaturity = true;
            this.transform.localScale += new Vector3(50.0f, 50.0f, 50.0f);
        }
    }

    //to determine how much water the plant is using 
    public void plantWater()
    {


        waterReserve -= waterUsageValue * Time.deltaTime;



        if (waterReserve == 30)
        {
            Debug.Log("Please water me.");
        }
        else if (waterReserve == 12)
        {
            Debug.Log("I am getting very thirsty.");
        }
        else if (waterReserve == 4)
        {
            Debug.Log("I am going to die");
        }


    }

    //to determine how much fertilizer the plant is using. 
    public void plantFertilizer()
    {

        fertilizerReserve -= fertilizerNeed * Time.deltaTime;

        if (fertilizerReserve == 30)
        {
            Debug.Log("Please fertilize me.");
        }
        else if (fertilizerReserve == 12)
        {
            Debug.Log("I am getting very hungry");
        }
        else if (fertilizerReserve == 4)
        {
            Debug.Log("I am going to die");
        }





    }
}
