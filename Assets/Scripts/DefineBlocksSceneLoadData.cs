using UnityEngine;

public class DefineBlocksSceneLoadData : MonoBehaviour
{
    public void DefineValues()
    {
        BlocksSceneLoadData.Count = 0;
        BlocksSceneLoadData.SceneNameOrder = new string[] { "BlocksPuzzle2x2 FilledInPicture", "BlocksPuzzle2x2 WithHint", "BlocksPuzzle2x2", "BlocksPuzzle3x3 FilledInPicture", "BlocksPuzzle3x3 WithHint", "BlocksPuzzle3x3"};
        BlocksSceneLoadData.TextureIndexes = new int[] {0, 1, 2, 3, 4, 5};
        ArrayAlgorithms.Shuffle.ShuffleArray(BlocksSceneLoadData.TextureIndexes, BlocksSceneLoadData.TextureIndexes.Length);
    }
}
