using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{

    public GameObject cameraOrbit;
    public float rotationSpeed = 8f;


   
    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButton(0))
        {
            //to transform mouse inputs into floats and add the correct speed
            float horizontalMouse = rotationSpeed * Input.GetAxis("Mouse X");
            float vertialMouse = rotationSpeed * Input.GetAxis("Mouse Y");

            //
            if (cameraOrbit.transform.eulerAngles.z + vertialMouse <= 0.1f || cameraOrbit.transform.eulerAngles.z + vertialMouse >= 179.9f)
            {
                vertialMouse = 0;
            }

            //movec the camera in the proper orbit around the object in question. 
                cameraOrbit.transform.eulerAngles = new Vector3(cameraOrbit.transform.eulerAngles.x, cameraOrbit.transform.eulerAngles.y + horizontalMouse, cameraOrbit.transform.eulerAngles.z + vertialMouse);

        }

       //adds a scroll function to the game.
        float scrollFactor = Input.GetAxis("Mouse ScrollWheel");
        Vector3 scaleVector = new Vector3();
        float maxScale = 5.0f;
        float minScale = 2.0f;
        

        // Using Mathf.clamp to make sure that the scale of the orbit for the camera does not get too big or too small
        if(scrollFactor!=0)
        {
            scaleVector.x = Mathf.Clamp(cameraOrbit.transform.localScale.x * (1f-scrollFactor), minScale, maxScale);
            scaleVector.y = Mathf.Clamp(cameraOrbit.transform.localScale.y * (1f - scrollFactor), minScale, maxScale);
            scaleVector.z = Mathf.Clamp(cameraOrbit.transform.localScale.z * (1f - scrollFactor), minScale, maxScale);
            cameraOrbit.transform.localScale = scaleVector;
           
                
            

        }
    }
}
