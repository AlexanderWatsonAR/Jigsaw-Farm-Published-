using UnityEngine;
using UnityEngine.UI;

public class SetText : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        if (GameObject.FindGameObjectWithTag("JigsawPieces") != null) // 'Block' scene.
        { 
            GameObject jigsawPieces = GameObject.FindGameObjectWithTag("JigsawPieces");
            CreateJigawPieces script = jigsawPieces.GetComponent<CreateJigawPieces>();
            GetComponent<Text>().text = script.Cartoon.name;
        }
        else // 'Shape' scene.
        {
            string text = GameObject.FindGameObjectWithTag("Board").GetComponent<MeshRenderer>().material.name;
            text = text.Remove(text.IndexOf('('));
            GetComponent<Text>().text = text;
        }
	}
}
