using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
	public void LoadScene(string sceneName)
	{
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
	}

    public void LoadSceneInSetOrder()
    {
        LoadScene(BlocksSceneLoadData.NextSceneName);
        BlocksSceneLoadData.Count++;
        Debug.Log(BlocksSceneLoadData.Count);
    }
}
