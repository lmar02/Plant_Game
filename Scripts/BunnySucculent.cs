using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[System.Serializable]
public class BunnySucculent : PlantAbstractTest
{



 




    // Start is called before the first frame update
    void Start()
    {
        
            //custom inputs for different plants 
            waterUsageValue = 0.2f;
            waterReserve = 100.0f;
            fertilizerNeed = 0.4f;
            fertilizerReserve = 100.0f;
            timeTillGermination = 30.0f;
            timeTillMaturity = 60.0f;
            scientificName = "Monilaria moniliformis";
            commonName = "Bunny Succulent";

            //default inputs
            oneRunGermination = false;
            oneRunMaturity = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        savedtime += Time.deltaTime;
        plantGrowth();
        plantWater();
        plantFertilizer();
    } 
    

    

    
}
