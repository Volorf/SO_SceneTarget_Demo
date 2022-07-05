using UnityEngine.SceneManagement;
using UnityEngine;

[CreateAssetMenu(menuName="Create a Scene Target")]
public class SceneTarget : ScriptableObject
{
    public string sceneName;

    public void GoToScene()
    {
        if(string.IsNullOrEmpty(sceneName)) return;
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
}