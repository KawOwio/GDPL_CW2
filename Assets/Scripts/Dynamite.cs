using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.youtube.com/watch?v=XMDfhHyOacM
//Tutorial used to make it

public class Dynamite : MonoBehaviour
{
    public GameObject bomb;
    public float power = 10.0f;
    public float radius = 5.0f;
    public float upForce = 1.0f;
    private bool explode = false;
    	
	void FixedUpdate ()
    {
        if (bomb == enabled)
        {
            if (explode == true)
            {
                Invoke("Detonate", 1);
            }
        }
	}

    void Detonate()
    {
        Vector3 explosionPosition = bomb.transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPosition, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(power, explosionPosition, radius, upForce, ForceMode.Impulse);
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Ball")
        {
            explode = true;
            Debug.Log(other.gameObject.name);
        }
    }
}
