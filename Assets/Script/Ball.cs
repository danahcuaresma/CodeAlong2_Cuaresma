using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{   
    float speed = 20f;
    Rigidbody rigidBody;
    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = Vector3.down * speed;
    }

    void FixedUpdate()
    {
        rigidBody.velocity = rigidBody.velocity.normalized * speed;
        velocity = rigidBody.velocity;
    }

    private void OnCollisionEnter(Collision collision) {
        rigidBody.velocity = Vector3.Reflect(velocity, collision.contacts[0].normal);
    }
}
