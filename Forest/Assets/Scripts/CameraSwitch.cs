using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera firstPersonCamera;
    public Camera thirdPersonCamera;

    // Start is called before the first frame update
    void Start()
    {
        firstPersonCamera.enabled = true;
        thirdPersonCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {

            if (firstPersonCamera.enabled == true)
            {
                firstPersonCamera.enabled = false;
                thirdPersonCamera.enabled = true;

            }

            else if(thirdPersonCamera.enabled == true)
            {
                firstPersonCamera.enabled = true;
                thirdPersonCamera.enabled = false;
            }
        }


    }
}
