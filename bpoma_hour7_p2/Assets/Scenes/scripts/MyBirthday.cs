using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int daysinMonth = 31;
        int birthday = 15;

        for(int day=1; day<= daysinMonth; day++)
        {
            if(day==birthday)
            {
                Debug.Log("Its my birthday!!");
            }
            else
            {
                Debug.Log(day);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
