using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckCompleted : MonoBehaviour
{
	public GameObject[] Slots;
    public GameObject board;
    public GameObject caption;
    public GameObject title;
    public GameObject buttonNextPuzzle;

    private string[] compliments = { "Well Done!", "Great Job!", "Nice Job!", "Keep it up!", "Sterling Work!", "Nice Going!", "Good Job!" };
    private bool isCompleted = false;

	// Update is called once per frame
	void Update()
	{
        if (isCompleted)
            return;
		int count = 0;
		foreach (GameObject slot in Slots)
			if (slot.GetComponent<CheckCorrectPiece>().IsCorrectPiece)
				count++;
		if (count == Slots.Length)
		{
            if (board.GetComponent<GridLayoutGroup>() != null)
            {
                board.GetComponent<GridLayoutGroup>().spacing = new Vector2();
            }
            if (board.GetComponent<Image>() != null)
            {
                board.GetComponent<Image>().enabled = true;
            }
			title.GetComponent<TextMeshProUGUI>().enabled = true;
            caption.GetComponent<TextMeshProUGUI>().enabled = true;
            if (caption.GetComponent<ChangeText>() != null)
            {
                caption.GetComponent<ChangeText>().enabled = false;
            }
            if (caption.GetComponent<Toggle>() != null)
            {
                caption.GetComponent<Toggle>().enabled = false;
            }
            int randomIndex = Random.Range(0, compliments.Length - 1);
            caption.GetComponent<TextMeshProUGUI>().text = "Correct. " + compliments[randomIndex];
            buttonNextPuzzle.GetComponent<TextMeshProUGUI>().enabled = true;
            isCompleted = true;
        } 
	}
}
