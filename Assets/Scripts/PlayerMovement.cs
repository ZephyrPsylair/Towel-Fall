using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
        public Rigidbody rb;
    public float BounceSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity = new Vector3(rb.velocity.x, BounceSpeed* Time.deltaTime, rb.velocity.z);

        string MaterialName = collision.transform.GetComponent<MeshRenderer>().material.name;
        
        if(MaterialName == "Black (Instance)")
        {
            GameManager.GameOver = true;
        }

        if (MaterialName == "Win (Instance)")
        {
            GameManager.GameWon = true;
        }
    }
}
