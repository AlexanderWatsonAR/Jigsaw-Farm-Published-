using UnityEngine;
using UnityEngine.UI;

public class CreateJigawPieces : MonoBehaviour
{
	public GameObject[] Slots;
    public Texture2D[] textures;
    public GameObject canvas;

	private Texture2D cartoon;
	private int columns;
	private int rows;
	private int height;
	private int width;

	public Texture2D Cartoon
	{
		get
		{
            if (cartoon == null)
                cartoon = textures[BlocksSceneLoadData.NextTextureIndex];
			return cartoon;
		}
        set
        {
            cartoon = value;
        }
	}
	
	void Start()
	{
		// Defines the size of each jigsaw piece.
		rows = GetComponent<GridLayoutGroup>().constraintCount;
		columns = rows;

		height = Cartoon.height / rows;
		width = Cartoon.width / columns;

		int count = 0;
		for (int i = 0; i < columns; i++)
		{
			for (int j = 0; j < rows; j++)
			{
				GameObject piece = CreatePiece(j*width, i*height);
				piece.GetComponent<RectTransform>().SetParent(Slots[count].transform, false);
				piece.name = "Piece " + count.ToString();
				count++;
			}
		}

		int flipACoin = Random.Range (0, 3);

		if (flipACoin == 0)
			GetComponent<GridLayoutGroup>().startCorner = GridLayoutGroup.Corner.LowerRight;
		if (flipACoin == 1)
			GetComponent<GridLayoutGroup>().startCorner = GridLayoutGroup.Corner.UpperRight;
	}

	GameObject CreatePiece(float xSpriteIndex, float ySpriteIndex)
	{
		Sprite newSprite = Sprite.Create(Cartoon, new Rect(xSpriteIndex, ySpriteIndex, width, height), new Vector2());
		
		GameObject piece = new GameObject();
		Image newImage = piece.AddComponent<Image>();
		newImage.sprite = newSprite;
		piece.AddComponent<Drag>();
		piece.AddComponent<CanvasGroup>();
        piece.GetComponent<Drag>().canvas = canvas;
        piece.layer = 5;
		return piece;
	}
}
