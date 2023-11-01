using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeOnTrigger : MonoBehaviour
{
    public string sceneToLoad; // The name of the scene to load
    public string tagName;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == tagName)
        {
            LoadNewScene();
        }
    }

    private void LoadNewScene()
    {
        this.gameObject.SetActive(false);
        // Load the specified scene
        SceneManager.LoadScene(sceneToLoad);
    }
}