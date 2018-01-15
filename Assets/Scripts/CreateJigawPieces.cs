using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CreateJigawPieces : MonoBehaviour
{
	public Texture2D Cartoon;
	public Texture2D White;
	public int Columns;
	public int Rows;
	
	void Start ()
	{
		// Defines the size of each jigsaw piece.
		int height = Cartoon.height / Rows;
		int width = Cartoon.width / Columns;

		// Adjusts the layout of the area according to the size & number of the jigsaw pieces.
		GridLayoutGroup grid = GetComponent<GridLayoutGroup>();
		grid.cellSize = new Vector2(Cartoon.width, Cartoon.height);
		grid.spacing = new Vector2(width, height);

		Board(width, height);

		//Creates pieces & corresponding slots.
		for (int i = 0; i < Columns; i++)
		{
			for (int j = 0; j < Rows; j++)
			{
				GameObject slot = CreateSlot(width, height);
				slot.GetComponent<RectTransform>().SetParent(gameObject.transform, false);
				// Points within the source texture to draw from.
				float xSpriteIndex = i*width;
				float ySpriteIndex = j*height;

				Sprite newSprite = Sprite.Create(Cartoon, new Rect(xSpriteIndex, ySpriteIndex, width, height), new Vector2());

				GameObject piece = new GameObject();
				Image newImage = piece.AddComponent<Image>();
				newImage.sprite = newSprite;
				piece.AddComponent<Drag>();
				piece.GetComponent<Drag>().ZPositionOnDrag = piece.transform.position.z;
				piece.AddComponent<CanvasGroup>();
				piece.GetComponent<RectTransform>().SetParent(slot.transform, false);
			}
		}
	}

	GameObject CreateSlot(int width, int height)
	{
		GameObject slot = new GameObject();
		Sprite newSprite = Sprite.Create(White, new Rect(0.0f, 0.0f, width, height), new Vector2());

		Image newImage = slot.AddComponent<Image>();
		newImage.sprite = newSprite;
		Color newColor = newImage.color;
		newColor.a = 0.5f;
		newImage.color = newColor;

		slot.AddComponent<Drop>();
		slot.GetComponent<Drop> ().MaximumNumberOfChildren = 1;
		slot.GetComponent<RectTransform>().localScale = new Vector3(((float)width / 100.0f), ((float)height / 100.0f), 1.0f);

		slot.AddComponent<HorizontalLayoutGroup>();
		slot.GetComponent<HorizontalLayoutGroup>().childAlignment = TextAnchor.MiddleCenter;
		slot.GetComponent<HorizontalLayoutGroup>().childForceExpandWidth = true;
		slot.GetComponent<HorizontalLayoutGroup>().childForceExpandHeight = true;

		return slot;
	}

	// Configure game board.
	void Board(int width, int height)
	{
		GameObject board = GameObject.FindGameObjectWithTag("Board");
		board.GetComponent<GridLayoutGroup>().cellSize = new Vector2(Cartoon.width, Cartoon.height);

		// NOTE: Board spacing configuration hard coded and only works on 3x3 grid.
		float boardLRTB = 384.0f;
		float spacing = 5.0f;
		board.GetComponent<GridLayoutGroup>().spacing = new Vector2 (-(boardLRTB/10.0f) + spacing , -(boardLRTB/10.0f) + spacing);

		int totalNumberofPieces = Rows * Columns;

		for (int i = 0; i < totalNumberofPieces; i++)
		{
			GameObject slot = CreateSlot(width, height);
			slot.GetComponent<RectTransform>().SetParent(board.GetComponent<RectTransform>(), false);
		}
	}

}
