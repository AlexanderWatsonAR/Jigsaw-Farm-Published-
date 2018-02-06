using System.Collections.Generic;
using UnityEngine;

namespace ArrayAlgorithms
{
    public class Shuffle
    {
        static public void ShuffleArray<T>(IList<T> collection, int size)
        {
            for (int i = size - 1; i > 0; i--)
            {
                // Pick a random index from 0 to i.
                int random = Random.Range(0, i);

                // Swap collection[i] with the element at the random index.
                var temp = collection[i];
                collection[i] = collection[random];
                collection[random] = temp;
            }
        }

    }
};
