using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public void GameBegin()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void BacktoTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
