using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    public Transform Player;
    public GameObject[] ChildRings;

    float Radius = 100f;
    float Force = 400f;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if(transform.position.y > Player.position.y)
        {
            for(int i = 0; i < ChildRings.Length; i++)
            {
                ChildRings[i].GetComponent<Rigidbody> ().isKinematic = false;
                ChildRings[i].GetComponent<Rigidbody>().useGravity = true;

                Collider[] colliders= Physics.OverlapSphere(transform.position, Radius);

                foreach(Collider newcollider in colliders)
                {
                    Rigidbody rb = newcollider.GetComponent<Rigidbody>();
                    if(rb != null)
                    {
                        rb.AddExplosionForce(Force, transform.position, Radius);    
                    }
                }
                ChildRings[i].transform.parent = null;
                Destroy(ChildRings[i].gameObject, 2f);
            }
            this.enabled = false;
        }
    }
}   

