using UnityEngine;

public class AssignMaterial : MonoBehaviour
{
    public Material[] Materials;

    // Use this for initialization
    void Awake()
    {
        GetComponent<MeshRenderer>().material = new Material(Materials[ShapesLoadData.MaterialIndexes[ShapesLoadData.MaterialArrayIndex]]);
    }
}
