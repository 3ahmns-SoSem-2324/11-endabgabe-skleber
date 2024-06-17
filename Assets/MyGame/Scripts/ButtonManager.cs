using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager: MonoBehaviour
{
    public void ExitFunction()
    {
        Application.Quit();
    }

    public void LoadTutorialScene()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    
}