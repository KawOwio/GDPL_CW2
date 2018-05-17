using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour
{
    private int move = 0;
    public Vector3 movement;

	// Update is called once per frame
	void Update ()
    {
		if (move > 0)
        {
            transform.Translate(movement * Time.deltaTime, Space.World);
            move--;
        }
	}

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Ball_3")
        {
            move = 10;
            Debug.Log(other.gameObject.name);
        }
    }
}
