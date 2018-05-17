using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject door;
    public Vector3 trans;
    private bool pressed = false;
    private int timer = 0;
	
	// Update is called once per frame
	void FixedUpdate ()
    {
		if (timer > 0)
        { 
            for (int i = 1; i < 3; i ++)
            {
                transform.Translate(1 * Time.deltaTime, 0 * Time.deltaTime, 0 * Time.deltaTime, Space.World);
            }
            
            for (int n = 0; n < 16; n++)
            {
                door.transform.Translate(5 * Time.deltaTime, 0 * Time.deltaTime, 0 * Time.deltaTime, Space.World);
            }
            timer--;
        }
	}

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Hand" && pressed == false)
        {
            timer = 5;
            pressed = true;
            Debug.Log(other.gameObject.name);
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.name == "Hand")
        {
            pressed = true;
            timer = 0;
            Debug.Log(other.gameObject.name);
            System.Console.WriteLine("Collision Exit");
        }
    }
}
