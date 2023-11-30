using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeOnTrigger : MonoBehaviour
{
    public string sceneToLoad; // The name of the scene to load
    public string tagName;
    public int gameMode = 1;

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
        GameManager.gameMode = gameMode;
        // Load the specified scene
        SceneManager.LoadScene(sceneToLoad);
    }
}