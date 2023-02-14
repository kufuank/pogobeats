using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicEmissionIntensity : MonoBehaviour
{
    public Material material;
    public AudioSource audioSource;
    public float emissionMultiplier = 1;

    private float[] samples = new float[512];

    private void Update()
    {
        audioSource.GetSpectrumData(samples, 0, FFTWindow.Blackman);
        float intensity = 0;
        for (int i = 0; i < samples.Length; i++)
        {
            intensity += samples[i];
        }
        intensity = intensity / samples.Length * emissionMultiplier;
        material.SetColor("_EmissionColor", new Color(137, intensity, 137));
    }
}