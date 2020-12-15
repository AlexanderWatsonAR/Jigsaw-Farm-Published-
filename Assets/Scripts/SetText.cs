using UnityEngine;
using TMPro;

public class SetText : MonoBehaviour
{
    public GameObject jigsawPieces;
    public GameObject board;

    // Use this for initialization
    void Start()
    {
        if (jigsawPieces != null) // 'Block' scene.
        { 
            CreateJigawPieces script = jigsawPieces.GetComponent<CreateJigawPieces>();
            GetComponent<TextMeshProUGUI>().text = script.Cartoon.name;
        }
        else // 'Shape' scene.
        {
            string text = board.GetComponent<MeshRenderer>().material.name;
            text = text.Remove(text.IndexOf('('));
            if(GetComponent<TextMeshProUGUI>() != null)
                GetComponent<TextMeshProUGUI>().text = text;
            else
                GetComponent<TextMeshPro>().text = text;
        }
	}
}
