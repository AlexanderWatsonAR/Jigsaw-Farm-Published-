using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text.RegularExpressions;

public class CheckCorrectPiece : MonoBehaviour
{
	private bool isCorrectPiece;

    private string[] compliments = { "Well Done!", "Great Job!", "Nice Job!", "Keep it up!", "Sterling Work!", "Nice Going!", "Good Job!" };

    public GameObject jigsawPieces;
    public GameObject board;
    public GameObject caption;
    public GameObject title;
    public GameObject buttonNextPuzzle;

    public int totalNumberOfPieces;

    public bool IsCorrectPiece 
	{
		get
		{
			return isCorrectPiece;
		}
        set
        {
            isCorrectPiece = value;
        }
	}

	// Use this for initialization
	void Start()
	{
		isCorrectPiece = false;
	}
	
    public void CheckPiece()
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

        if (pieceNumber == slotNumber)
            isCorrectPiece = true;
        else
            isCorrectPiece = false;

        CheckCompleted();
    }

    private void CheckCompleted()
    {
        int count = 0;
        if (isCorrectPiece)
            count++;

        for (int i = 0; i < transform.parent.childCount; i++)
        {
            if(transform.parent.GetChild(i).name != name)
            {
                if(transform.parent.GetChild(i).GetComponent<CheckCorrectPiece>().IsCorrectPiece == true)
                {
                    count++;
                }
            }
        }

        if (count != totalNumberOfPieces)
            return;

        foreach (Drag d in FindObjectsOfType<Drag>())
        {
            d.enabled = false;
        }

        if (board.GetComponent<GridLayoutGroup>() != null)
        {
            board.GetComponent<GridLayoutGroup>().spacing = new Vector2();
        }
        if (board.GetComponent<Image>() != null)
        {
            board.GetComponent<Image>().enabled = true;
        }

        if(title.GetComponent<TextMeshProUGUI>() != null)
            title.GetComponent<TextMeshProUGUI>().enabled = true;
        else
            title.GetComponent<TextMeshPro>().enabled = true;

        if (caption.GetComponent<TextMeshProUGUI>() != null)
            caption.GetComponent<TextMeshProUGUI>().enabled = true;
        else
            caption.GetComponent<TextMeshPro>().enabled = true;

        if (caption.GetComponent<ChangeText>() != null)
        {
            caption.GetComponent<ChangeText>().enabled = false;
        }
        if (caption.GetComponent<Toggle>() != null)
        {
            caption.GetComponent<Toggle>().enabled = false;
        }
        int randomIndex = Random.Range(0, compliments.Length - 1);

        if(caption.GetComponent<TextMeshProUGUI>() != null)
            caption.GetComponent<TextMeshProUGUI>().text = "Correct. " + compliments[randomIndex];
        else
            caption.GetComponent<TextMeshPro>().text = "Correct. " + compliments[randomIndex];

        if(buttonNextPuzzle.GetComponent<TextMeshProUGUI>() != null)
            buttonNextPuzzle.GetComponent<TextMeshProUGUI>().enabled = true;
        else
            buttonNextPuzzle.GetComponent<TextMeshPro>().enabled = true;

        if (jigsawPieces != null)
            jigsawPieces.SetActive(false);
    }
}
