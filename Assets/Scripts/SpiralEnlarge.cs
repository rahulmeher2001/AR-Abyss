using System.Collections;
using UnityEngine;

public class SpiralEnlarge : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public GameObject targetObject; // The GameObject to scale and spiral
    public GameObject deleteObject;
    public GameObject displayObject;

    public float scaleSpeed = 0.5f; // Speed of scaling
    public float spiralSpeed = 1.0f; // Speed of spiraling
    public float enlargeTime = 1.0f; // Time for which spiral increases
    public float spawnDepth = 1.0f; //distance under which spiral spawns

    private float timer = 0.0f;
    private bool shouldEnlarge = true;
    private bool initiateSpiral = false;

    private void Update()
    {
        if (initiateSpiral)
        {
            if (targetObject == null)
            {
                Debug.LogError("Please assign targetObject and spiralCenterObject in the inspector.");
                return;
            }

            if (shouldEnlarge)
            {
                // Scale the targetObject
                Vector3 scale = targetObject.transform.localScale;
                scale += Vector3.one * scaleSpeed * Time.deltaTime;
                targetObject.transform.localScale = scale;
            }

            // Track time
            timer += Time.deltaTime;

            // Stop enlarging after 1 second
            if (timer >= enlargeTime)
            {
                shouldEnlarge = false;
            }
        }
    }

    public void createSpiral()
    {
        if (displayObject)
        {
            displayObject.SetActive(true);
        }
        // Calculate the position for the new empty GameObject
        Vector3 newPosition = this.transform.position - Vector3.up * spawnDepth;

        targetObject = Instantiate(prefabToSpawn);
        targetObject.transform.position = newPosition;
        initiateSpiral = true;
        Destroy(deleteObject);
    }
}
