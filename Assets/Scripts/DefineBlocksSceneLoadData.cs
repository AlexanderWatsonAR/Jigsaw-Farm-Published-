using UnityEngine;

public class DefineBlocksSceneLoadData : MonoBehaviour
{
    public void DefineValues2x2()
    {
        BlocksSceneLoadData.Count = 0;
        //BlocksSceneLoadData.SceneNameOrder = new string[15];
        //for(int i = 0; i < BlocksSceneLoadData.SceneNameOrder.Length; i++)
        //{
        //    BlocksSceneLoadData.SceneNameOrder[i] = "BlocksPuzzle2x2 WithHint";
        //}
        BlocksSceneLoadData.TextureIndexes = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 , 18, 19, 20, 21 , 22, 23, 24};
        ArrayAlgorithms.Shuffle.ShuffleArray(BlocksSceneLoadData.TextureIndexes, BlocksSceneLoadData.TextureIndexes.Length);
        BlocksSceneLoadData.IsFadeInEnabled = true;
    }

    public void DefineValues3x3()
    {
        BlocksSceneLoadData.Count = 0;
        //BlocksSceneLoadData.SceneNameOrder = new string[15];
        //for (int i = 0; i < BlocksSceneLoadData.SceneNameOrder.Length; i++)
        //{
        //    BlocksSceneLoadData.SceneNameOrder[i] = "BlocksPuzzle3x3 WithHint";
        //}
        BlocksSceneLoadData.TextureIndexes = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
        ArrayAlgorithms.Shuffle.ShuffleArray(BlocksSceneLoadData.TextureIndexes, BlocksSceneLoadData.TextureIndexes.Length);
        BlocksSceneLoadData.IsFadeInEnabled = true;
    }
}
