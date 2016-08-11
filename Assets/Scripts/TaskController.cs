using UnityEngine;
using UnityEngine.SceneManagement;

public class TaskController : TaskElement {

    public void OnColorChange(Renderer rend) { rend.material.SetColor("_Color", TaskModel.color); }

    public void OnSetColor(Color color) { TaskModel.color = color; }

    public void OnLoadScene(string sceneName) { SceneManager.LoadScene(sceneName); }

    public void OnButtonRed()
    {
        OnSetColor(Color.red);
        OnLoadScene("02_GameScene");
    }

    public void OnButtonBlue()
    {
        OnSetColor(Color.blue);
        OnLoadScene("02_GameScene");
    }

    public void OnButtonBack()
    {
        OnLoadScene("01_MainMenu");
    }
}
