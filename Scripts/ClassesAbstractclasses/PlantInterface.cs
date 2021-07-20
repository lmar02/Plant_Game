using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface PlantInterface
{
    //variables needed for plant // obsolete currently - leaving in just in case I need it in the future
    float waterUsageValue { get; set; }
    float waterReserve { get; set; }
    float fertilizerNeed { get; set; }
    float fertilizerReserve { get; set; }
    float timeTillGermination { get; set; }
    float timeTillMaturity { get; set; }
    string scientificName { get; set; }
    string commonName { get; set; }


    //initializer
    //public void Initialize();

    
}
