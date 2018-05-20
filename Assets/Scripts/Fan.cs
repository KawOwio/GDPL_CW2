using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    public int JUMP_HEIGHT;
    public Vector3 trans;
    private int velocity;
    public GameObject ball;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (velocity > 0)
        {
            ball.transform.Translate(trans * Time.deltaTime, Space.World);
            velocity--;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Ball")
        {
            velocity = JUMP_HEIGHT;

            Debug.Log(other.gameObject.name);
        }
    }
}
