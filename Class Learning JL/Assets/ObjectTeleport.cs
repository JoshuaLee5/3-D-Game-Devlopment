using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTeleport : MonoBehaviour
{
    public Transform spawnpoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball") // check that collider entering is tagged 'ball'
        {
            if (other.TryGetComponent(out Rigidbody rb) == true) //get rigidbody for colliding object
            {
                rb.velocity = Vector3.zero; //reset rigidbody velocity to 0 to stop movement
            }
            other.transform.position = spawnpoint.position; //move colliding object to spawn positing
        }

    }
}
