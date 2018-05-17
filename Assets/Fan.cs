using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    public int JUMP_HEIGHT;
    public Vector3 trans;
    private int velocity;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (velocity > 0)
        {
            transform.Translate(trans * Time.deltaTime, Space.World);
            velocity--;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Bounce")
        {
            velocity = JUMP_HEIGHT;

            Debug.Log(other.gameObject.name);
        }
    }
}
