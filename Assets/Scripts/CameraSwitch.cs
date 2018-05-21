using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://answers.unity.com/questions/16146/changing-between-cameras.html
//Tutorial used to make it

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
    }
	
	void Update ()
    {
        //Check for every camera
        for (int i = 0; i < 5; i++)
        {
            if (balls[i].GetComponent<BallCollision>().nextCamera == true)
            {
                currentCameraIndex++;
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

