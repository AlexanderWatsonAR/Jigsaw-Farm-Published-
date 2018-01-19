using UnityEngine;
using System.Collections;
using System.Text.RegularExpressions;

public class CheckCorrectPiece : MonoBehaviour
{
	private bool isCorrectPiece;

	public bool IsCorrectPiece 
	{
		get
		{
			return isCorrectPiece;
		}
	}

	// Use this for initialization
	void Start()
	{
		isCorrectPiece = false;
	}
	
	// Update is called once per frame
	void Update()
	{
		if (!GetComponent<Drop>().AtMaxChildNumber)
		{
			isCorrectPiece = false;
			return;
		}

		Transform piece = transform.GetChild(transform.childCount - 1);
		string pieceResult = Regex.Match(piece.name, @"\d+").Value;
		string slotResult = Regex.Match(name, @"\d+").Value;

		int pieceNumber = int.Parse(pieceResult);
		int slotNumber = int.Parse(slotResult);

		if(pieceNumber == slotNumber)
			isCorrectPiece = true;
		else
			isCorrectPiece = false;
	}
}
