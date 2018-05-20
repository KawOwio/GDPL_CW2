using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour {

    public bool nextCamera = false;
    public bool wasPressed = false;

    private void OnCollisionEnter(Collision trigger)
    {
        if (trigger.gameObject.tag == "CameraMove" && nextCamera == false)
        {
            nextCamera = true;
            wasPressed = true;
            Debug.Log(trigger.gameObject.name);
        }
    }
}