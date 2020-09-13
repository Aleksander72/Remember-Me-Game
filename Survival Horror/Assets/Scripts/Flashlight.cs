using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public new Light light;
    public GameObject flashlight;
    void Start()
    {
        light.GetComponent<Light>();
        light.enabled = false;
    }
    void Update()
    {
        //flashlight.transform.position = Camera.main.transform.position + Vector3.right * 1.2f + Vector3.forward * 1.43f;

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (light.enabled == false)
            {
                light.enabled = true;
            }
            else if(light.enabled == true)
            {
                light.enabled = false;
            }
        }
    }

}
