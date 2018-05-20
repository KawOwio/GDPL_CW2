using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera[] cameras;
    private int currentCameraIndex;
    public GameObject[] balls;      //Triggers of switching to a next camera
	
	void Start ()
    {
        currentCameraIndex = 0;

        //Turn all cameras off, except the first default one
        for (int i = 1; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(false);
        }

        //If any cameras were added to the controller, enable the first one
        if (cameras.Length > 0)
        {
            cameras[0].gameObject.SetActive(true);
            Debug.Log("Camera with name: " + cameras[0].name + ", is now enabled");
        }

    }
	
	void Update ()
    {
        for (int i = 0; i < 5; i++)
        {
            if (balls[i].GetComponent<BallCollision>().nextCamera == true)
            {
                currentCameraIndex++;
                Debug.Log("Switching to the next camera");
                if (currentCameraIndex < cameras.Length)
                {
                    cameras[currentCameraIndex - 1].gameObject.SetActive(false);
                    cameras[currentCameraIndex].gameObject.SetActive(true);
                    Debug.Log(cameras[currentCameraIndex].name + ", is now enabled");
                }
                balls[i].GetComponent<BallCollision>().nextCamera = false;
            }
        }
    }
}

