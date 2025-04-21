using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    private string triggerName;

    void Start()
    {
        triggerName = gameObject.name;
        GetComponent<Collider>().isTrigger = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.GetComponent<MotionScript>() != null)
        {
            Debug.Log("Sphere entered " + triggerName);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") || other.GetComponent<MotionScript>() != null)
        {
            Debug.Log("Sphere staying in " + triggerName);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.GetComponent<MotionScript>() != null)
        {
            Debug.Log("Sphere exited " + triggerName);
        }
    }
}
