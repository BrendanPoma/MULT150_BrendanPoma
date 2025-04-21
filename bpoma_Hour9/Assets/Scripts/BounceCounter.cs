using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    private int collisionCount = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<MotionScript>() != null || other.CompareTag("Player"))
        {
            IncrementAndLogCount();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<MotionScript>() != null ||
            collision.gameObject.CompareTag("Player"))
        {
            IncrementAndLogCount();
        }
    }

    private void IncrementAndLogCount()
    {
        collisionCount++;

        Debug.Log("Bounce count = " + collisionCount);
    }
}
