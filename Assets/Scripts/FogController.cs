using UnityEngine;

public class FogController : MonoBehaviour
{
    public bool enableFog = true;
    public Color fogColor = Color.gray;
    public float fogDensity = 0.02f;

    private void Update()
    {
        RenderSettings.fog = enableFog;
        RenderSettings.fogColor = fogColor;
        RenderSettings.fogDensity = fogDensity;
    }
}
