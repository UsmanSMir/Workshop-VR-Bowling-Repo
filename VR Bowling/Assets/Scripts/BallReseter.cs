using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReseter : MonoBehaviour
{
    public Transform m_ballSpawn;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bowling Ball")
        {
            other.transform.position = m_ballSpawn.position;
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
