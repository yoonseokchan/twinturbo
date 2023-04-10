using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotaton : MonoBehaviour
{
    float rotspeed = 0;
   

   
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.rotspeed = 10000;
        }

        transform.Rotate(0, this.rotspeed * Time.deltaTime, 0);

        rotspeed *= 0.99f;
    }
}
