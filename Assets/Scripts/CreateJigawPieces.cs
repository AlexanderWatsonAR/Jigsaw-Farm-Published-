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
		GridLayoutGroup grid = this.GetComponent<GridLayoutGroup>();
		grid.cellSize = new Vector2(Cartoon.width, Cartoon.height);
		grid.spacing = new Vector2(width, height);

		Board(width, height);

		for (int i = 0; i < Columns; i++)
		{
			for (int j = 0; j < Rows; j++)
			{
				GameObject newSlot = CreateSlot(width, height);
				newSlot.transform.SetParent(gameObject.transform, false);

				// Points within the source texture to draw from.
				int xSpriteIndex = i*width;
				int ySpriteIndex = j*height;

				Sprite newSprite = Sprite.Create(Cartoon, new Rect(xSpriteIndex, ySpriteIndex, width, height), new Vector2());

				GameObject newPiece = new GameObject();
				newPiece.AddComponent<SpriteRenderer>();
				newPiece.GetComponent<SpriteRenderer>().sprite = newSprite;
				newPiece.GetComponent<SpriteRenderer>().sortingOrder = 101;
				newPiece.AddComponent<Drag>();
				newPiece.AddComponent<BoxCollider2D>();
				newPiece.transform.SetParent(newSlot.transform, false);
				newPiece.tag = "Piece";
			}
		}
	}

	GameObject CreateSlot(int width, int height)
	{
		GameObject slot = new GameObject();
		Sprite newSprite = Sprite.Create(White, new Rect(0.0f, 0.0f, width, height), new Vector2());
		slot.AddComponent<SpriteRenderer>();
		slot.GetComponent<SpriteRenderer>().sprite = newSprite;
		Color temp = slot.GetComponent<SpriteRenderer>().color;
		temp.a = 0.5f;
		slot.GetComponent<SpriteRenderer>().color = temp;
		slot.AddComponent<RectTransform>();
		slot.AddComponent<Drop>();
		slot.transform.localScale = new Vector3(Cartoon.width, Cartoon.height, 1.0f);
		slot.tag = "Slot";
		slot.AddComponent<GridLayoutGroup>();
		GridLayoutGroup grid = slot.GetComponent<GridLayoutGroup>();
		grid.cellSize = new Vector2(width, height);
		grid.childAlignment = TextAnchor.MiddleCenter;
		return slot;
	}

	// Configure game board.
	void Board(int width, int height)
	{
		GameObject board = GameObject.FindGameObjectWithTag("Board");
		Vector2 boardSize = board.GetComponent<RectTransform>().sizeDelta;
		float cellWidth = -boardSize.x / Columns;
		float cellHeight = -boardSize.y / Rows;
		board.GetComponent<GridLayoutGroup>().cellSize = new Vector2(Cartoon.width, Cartoon.height);

		int totalNumberofPieces = Rows * Columns;

		for (int i = 0; i < totalNumberofPieces; i++)
		{
			GameObject newSlot = CreateSlot(width, height);
			newSlot.transform.SetParent(board.transform, false);
		}
	}

}
