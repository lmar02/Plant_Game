using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveLoadHandler
{ 

    //saves each plant that is currently in the game
    private Save CreateSaveGameObject()
    {
        Save save = new Save();
        GameObject[] plants = GameObject.FindGameObjectsWithTag("Plant");
        foreach (GameObject plant in plants)
        {
         
            
            save.plantFert.Add(plant.GetComponent<PlantAbstractTest>().fertilizerReserve);
            save.plantType.Add(1);
            save.plantWater.Add(plant.GetComponent<PlantAbstractTest>().waterReserve);
        }
        save.savedDateTime = DateTime.Now;
        return save;
    }

    //saves the game to a file.
    public void SaveGame()
    {
        Save save = CreateSaveGameObject();

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
        bf.Serialize(file, save);
        file.Close();
        Debug.Log("Save Successful");
    }

    public void LoadGame()
    { 
        if (File.Exists(Application.persistentDataPath + "/gamesave.save"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.save", FileMode.Open);
            Save save = (Save)bf.Deserialize(file);
            file.Close();


        }
    }

}

//saved game gameObject
[Serializable]
public class Save
{
    public List<float> plantWater = new List<float>();
    public List<float> plantFert = new List<float>();
    public List<float> plantType = new List<float>();
    public DateTime savedDateTime;

}

