using UnityEngine;

public class DotsManager : MonoBehaviour
{
    [SerializeField] int dots;
    ManageScene sceneManagement;

    void Start() => sceneManagement = FindObjectOfType<ManageScene>();

    public void CountDots() => dots++;

    public void RemoveDot()
    {
        dots--;
        if (dots == 0)
            sceneManagement.LoadScene(ManageScene.Scenes.Win);
    }
}