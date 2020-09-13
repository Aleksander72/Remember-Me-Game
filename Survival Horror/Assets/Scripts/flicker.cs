using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flicker : MonoBehaviour
{
    Light light;

    void Start()
    {
        light = GetComponent<Light>();
        StartCoroutine(flickingDelay());
    }

    public IEnumerator flickingDelay()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0.08f, 0.55f));
            light.enabled = !light.enabled;
        }
    }
}