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
            string cartoonName = script.Cartoon.name;
            cartoonName = cartoonName.Replace('1', ' ');
            GetComponent<TextMeshProUGUI>().text = cartoonName;
        }
        else // 'Shape' scene.
        {
            string text = board.GetComponent<MeshRenderer>().material.name;
            text = text.Remove(text.IndexOf('('));
            text = text.Replace('1', ' ');
            if(GetComponent<TextMeshProUGUI>() != null)
                GetComponent<TextMeshProUGUI>().text = text;
            else
                GetComponent<TextMeshPro>().text = text;
        }
	}
}
