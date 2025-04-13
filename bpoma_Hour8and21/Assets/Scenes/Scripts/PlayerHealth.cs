using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    int healthpoints = 3992;

    void Start()
    {
        healthpoints = usePotion(healthpoints);
        healthpoints = usePotion(healthpoints);
        healthpoints = usePotion(healthpoints);
        healthpoints = usePotion(healthpoints);

        Debug.Log(healthpoints);
    }

    void Update()
    {
        
    }

    int usePotion(int health)
    {
        return health + 400;
    }
}
