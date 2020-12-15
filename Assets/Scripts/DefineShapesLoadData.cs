using UnityEngine;

public class DefineShapesLoadData : MonoBehaviour
{
    public void DefineValues()
    {
        ShapesLoadData.MaterialArraySize = 14;
        ShapesLoadData.MaterialIndexes = new int[ShapesLoadData.MaterialArraySize];
        ShapesLoadData.MaterialArrayIndex = -1;
        ShapesLoadData.ModelArraySize = 26;
        ShapesLoadData.ModelArrayIndex = -1;

        for(int i = 0; i < ShapesLoadData.MaterialIndexes.Length; i++)
        {
            ShapesLoadData.MaterialIndexes[i] = i;
        }

        ArrayAlgorithms.Shuffle.ShuffleArray(ShapesLoadData.MaterialIndexes, ShapesLoadData.MaterialIndexes.Length);
    }
}
