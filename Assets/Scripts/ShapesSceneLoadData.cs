
public static class ShapesLoadData
{
    private static int modelArraySize;
    private static int modelArrayIndex;
    private static int materialArraySize;
    private static int materialArrayIndex;

    public static int ModelArraySize
    {
        get
        {
            return modelArraySize;
        }

        set
        {
            modelArraySize = value;
        }
    }

    public static int ModelArrayIndex
    {
        get
        {
            return modelArrayIndex = modelArrayIndex > modelArraySize - 1 ? 0 : modelArrayIndex;
        }

        set
        {
            modelArrayIndex = value;
        }
    }

    public static int MaterialArraySize
    {
        get
        {
            return materialArraySize;
        }

        set
        {
            materialArraySize = value;
        }
    }

    public static int MaterialArrayIndex
    {
        get
        {
            return materialArrayIndex = materialArrayIndex > materialArraySize - 1 ? 0 : materialArrayIndex;
        }

        set
        {
            materialArrayIndex = value;
        }
    }
}
