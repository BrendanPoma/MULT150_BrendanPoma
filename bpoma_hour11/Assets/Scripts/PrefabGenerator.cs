using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        float spacing = 5.0f;

        for (int i = 0; i < 10; i++)
        {
            Vector3 lampPosition = transform.position + new Vector3(i * spacing, 0, 0);

            Instantiate(prefab, lampPosition, transform.rotation);
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
