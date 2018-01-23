using UnityEngine;
using UnityEngine.UI;

public class SetTexture : MonoBehaviour
{
	// Use this for initialization
	void Start()
	{
		GameObject jigsawPieces = GameObject.FindGameObjectWithTag("JigsawPieces");
		CreateJigawPieces script = jigsawPieces.GetComponent<CreateJigawPieces>();
		Image newImage = gameObject.GetComponent<Image>();
		newImage.sprite = Sprite.Create(script.Cartoon, new Rect(0, 0, script.Cartoon.width, script.Cartoon.height), new Vector2());
	}
}
