using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CreateJigawPieces : MonoBehaviour
{
	public Texture2D[] Textures;
	public GameObject[] Slots;

	private Texture2D cartoon;
	private int columns;
	private int rows;
	private int height;
	private int width;
	
	void Awake ()
	{
		// Defines the size of each jigsaw piece.
		rows = 3;
		columns = 3;
		cartoon = Textures [Random.Range (0, Textures.Length)]; // Grabs Random texture.

		height = cartoon.height / rows;
		width = cartoon.width / columns;

		int count = 0;
		for (int i = 0; i < columns; i++)
		{
			for (int j = 0; j < rows; j++)
			{
				CreatePiece(i*width, j*height).GetComponent<RectTransform>().SetParent(Slots[count].transform, false);
				count++;
			}
		}

	}

	GameObject CreatePiece(float xSpriteIndex, float ySpriteIndex)
	{
		Sprite newSprite = Sprite.Create(cartoon, new Rect(xSpriteIndex, ySpriteIndex, width, height), new Vector2());
		
		GameObject piece = new GameObject();
		Image newImage = piece.AddComponent<Image>();
		newImage.sprite = newSprite;
		piece.AddComponent<Drag>();
		piece.GetComponent<Drag>().ZPositionOnDrag = piece.transform.position.z;
		piece.AddComponent<CanvasGroup>();
		return piece;
	}
}
