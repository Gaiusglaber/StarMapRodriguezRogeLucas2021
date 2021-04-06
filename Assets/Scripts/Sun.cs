using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public List<Light> lights;
    private bool switchlights;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Light light in lights)
        {
            if (light.intensity<=0.0f)
            {
                switchlights = true;
            }else if (light.intensity>=30.0f)
            {
                switchlights = false;
            }
            if (switchlights)
            {
                light.intensity += 0.01f;
            }
            else
            {
                light.intensity -= 0.01f;
            }
        }
    }
}
