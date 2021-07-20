using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    //target the camera needs to look at
    public Transform cameraTarget;
    //CameraOrbit
    public Transform cameraOrbit;

    // Start is called before the first frame update
    void Start()
    {
        cameraOrbit.position = cameraTarget.position;
    }

    // Update is called once per frame
    void Update()
    {

        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0);
        transform.LookAt(cameraTarget.position);
        
        
    }
}
