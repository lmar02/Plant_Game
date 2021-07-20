using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterBarController : MonoBehaviour
{

    //variables needed
    public GameObject plantGameObject;
    BunnySucculent script;
    public Slider waterBar;
    public Slider fertBar;
    // Start is called before the first frame update
    void Start()
    {
        script = plantGameObject.GetComponent<BunnySucculent>();
    }

    // Update is called once per frame
    void Update()
    {
        waterBar.value = script.waterReserve;
        fertBar.value = script.fertilizerReserve;
    }
}
