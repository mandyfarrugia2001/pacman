using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public partial class ManageScene : MonoBehaviour
{
    public void LoadNextScene()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(sceneIndex);
    }

    public void GoBackToPreviousScene()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex - 1;
        SceneManager.LoadScene(sceneIndex);
    }

    public void LoadScene(string scene)
    {
        switch(scene)
        {
            case "Menu":
                SceneManager.LoadScene("Menu");
                break;
            case "Instructions":
                SceneManager.LoadScene("Instructions");
                break;
            case "Main":
                SceneManager.LoadScene("Main");
                break;
            case "Win":
                SceneManager.LoadScene("Win");
                break;
            case "Lose":
                SceneManager.LoadScene("Lose");
                break;
            default:
                Debug.LogError("Invalid scene!");
                break;
        }
    }

    public void LoadScene(Scenes scene)
    {
        switch (scene)
        {
            case Scenes.Menu:
                SceneManager.LoadScene("Menu");
                break;
            case Scenes.Instructions:
                SceneManager.LoadScene("Instructions");
                break;
            case Scenes.Main:
                SceneManager.LoadScene("Main");
                break;
            case Scenes.Win:
                SceneManager.LoadScene("Win");
                break;
            case Scenes.Lose:
                SceneManager.LoadScene("Lose");
                break;
        }
    }

    public void Quit()
    {
        #if UNITY_EDITOR
            EditorApplication.isPlaying = false;
        #elif UNITY_STANDALONE
            Application.Quit();
        #endif
    }
}
