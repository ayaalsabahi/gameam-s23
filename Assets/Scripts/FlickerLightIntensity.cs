using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLightIntensity : MonoBehaviour
{
    private Light lightComponent = null;
    [Range(0, 8)]
    public float baseIntensity = 1; // Overrides the light component's intensity
    [Range(0, 5)]
    public float flickerStrength = 1;
    [Range(0.1f, 5)]
    public float flickerFrequency = 1;
    [Range(1, 60)]
    public float framesPerSecond = 60;

    void Start()
    {
        lightComponent = GetComponent<Light>();
        lightComponent.intensity = baseIntensity;
    }

    // Update is called once per frame
    void Update()
    {
        float time = Mathf.Floor(Time.time * framesPerSecond) / framesPerSecond;
        if (lightComponent == null)
            lightComponent = GetComponent<Light>();
        float newIntensity = baseIntensity + flickerStrength * Mathf.PerlinNoise(time * flickerFrequency, 0);
        lightComponent.intensity = Mathf.Clamp(newIntensity, 0, Mathf.Infinity);
    }
}
