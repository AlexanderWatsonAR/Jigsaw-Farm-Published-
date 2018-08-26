using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
	public void LoadScene(string sceneName)
	{
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
	}

    public void LoadBlocksSceneInSetOrder()
    {
        LoadScene(BlocksSceneLoadData.NextSceneName);
        BlocksSceneLoadData.Count++;
    }

    public void LoadShapesSceneInSetOrder()
    {
        LoadScene("MatchTheShapesGame");
        ShapesLoadData.MaterialArrayIndex++;
        ShapesLoadData.ModelArrayIndex++;
    }

    public void LoadJigsawSceneInSetOrder()
    {
        LoadScene("JigsawGame2x2");
        ShapesLoadData.MaterialArrayIndex++;
        ShapesLoadData.ModelArrayIndex++;
    }
}
