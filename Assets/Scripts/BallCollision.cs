using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour {

    public bool nextCamera = false;

    private void OnCollisionEnter(Collision trigger)
    {
        if (trigger.gameObject.tag == "CameraMove" && nextCamera == false)
        {
            nextCamera = true;
            Debug.Log(trigger.gameObject.name);
        }
    }
}