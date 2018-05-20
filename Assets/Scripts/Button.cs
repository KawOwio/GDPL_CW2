using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject door;
    public Vector3 translateButton;
    public Vector3 translateDoor;
    private bool pressed = false;
    private int timer = 0;
    public int TRANSFORM_TIMES;
	
	// Update is called once per frame
	void FixedUpdate ()
    {
		if (timer > 0)
        { 
            for (int i = 1; i < 3; i ++)
            {
                transform.Translate(translateButton * Time.deltaTime, Space.World);
            }
            
            for (int n = 0; n < TRANSFORM_TIMES; n++)
            {
                door.transform.Translate(translateDoor * Time.deltaTime, Space.World);
            }
            timer--;
        }
	}

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Collision" && pressed == false)
        {
            timer = 5;
            pressed = true;
            Debug.Log(other.gameObject.name);
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Collision")
        {
            pressed = true;
            //timer = 0;
            Debug.Log(other.gameObject.name);
            System.Console.WriteLine("Collision Exit");
        }
    }
}
