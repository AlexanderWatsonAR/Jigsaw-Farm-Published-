
public static class ShapesLoadData
{
    private static int modelArraySize;
    private static int modelArrayIndex;
    private static int materialArraySize;
    private static int materialArrayIndex;
    private static int[] materialIndexes;
    private static bool isFadeInEnabled;
    //private static string[] materialArrayNames;

    //public static string[] MaterialArrayNames
    //{
    //    get
    //    {
    //        return materialArrayNames;
    //    }

    //    set
    //    {
    //        materialArrayNames = value;
    //    }
    //}

    public static int[] MaterialIndexes
    {
        get
        {
            return materialIndexes;
        }

        set
        {
            materialIndexes = value;
        }
    }

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
