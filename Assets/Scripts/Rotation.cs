﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speed = 100.0f;

	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);
	}
}
