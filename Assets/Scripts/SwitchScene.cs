using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
	public void LoadScene(string sceneName)
	{
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
	}

    public void LoadBlocks2x2SceneInSetOrder()
    {
        LoadScene("BlocksPuzzle2x2 WithHint");
        //LoadScene(BlocksSceneLoadData.NextSceneName);
        BlocksSceneLoadData.Count++;
    }

    public void LoadBlocks3x3SceneInSetOrder()
    {
        LoadScene("BlocksPuzzle3x3 WithHint");
        //LoadScene(BlocksSceneLoadData.NextSceneName);
        BlocksSceneLoadData.Count++;
    }

    public void LoadShapesSceneInSetOrder()
    {
        LoadScene("MatchTheShapesGame");
        ShapesLoadData.MaterialArrayIndex++;
        ShapesLoadData.ModelArrayIndex++;
    }

    public void LoadJigsaw2x2SceneInSetOrder()
    {
        LoadScene("JigsawGame2x2");
        ShapesLoadData.MaterialArrayIndex++;
        ShapesLoadData.ModelArrayIndex++;
    }

    public void LoadJigsaw3x3SceneInSetOrder()
    {
        LoadScene("JigsawGame3x3");
        ShapesLoadData.MaterialArrayIndex++;
        ShapesLoadData.ModelArrayIndex++;
    }
}
