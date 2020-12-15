
public static class BlocksSceneLoadData
{
    private static int count;
    private static int[] textureIndexes;
    private static string[] sceneNameOrder;
    private static bool isFadeInEnabled;

    public static int Count
    {
        get
        {
            return count = count > textureIndexes.Length - 1 ? 0 : count;
        }

        set
        {
            count = value;
        }
    }

    public static int[] TextureIndexes
    {
        get
        {
            return textureIndexes;
        }
        set
        {
            textureIndexes = value;
        }
    }

    public static string[] SceneNameOrder
    {
        get
        {
            return sceneNameOrder;
        }
        set
        {
            sceneNameOrder = value;
        }
    }

    public static string NextSceneName
    {
        get
        {
            return sceneNameOrder[Count];
        }
    }

    public static int NextTextureIndex
    {
        get
        {
            return textureIndexes[Count];
        }
    }

    public static bool IsFadeInEnabled
    {
        get
        {
            return isFadeInEnabled;
        }
        set
        {
            isFadeInEnabled = value;
        }
    }
}
