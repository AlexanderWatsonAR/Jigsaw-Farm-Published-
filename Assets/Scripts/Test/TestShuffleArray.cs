using UnityEngine;

public class TestShuffleArray : MonoBehaviour
{
    public Material[] materials;

	// Use this for initialization
	void Start ()
    {
        ArrayAlgorithms.Shuffle.ShuffleArray(materials, materials.Length);

        for (int i = 0; i < materials.Length; i++)
        {
            Debug.Log(materials[i].name);
        }
	}
}
